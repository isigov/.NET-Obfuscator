using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Mono.Cecil;
using Mono.Cecil.Cil;
using System.Threading;
using Mono.Cecil.Binary;
using System.Diagnostics;
using System.IO;

namespace Darkfuscator
{
    public partial class frmMain : Form
    {
        Random r = new Random();
        AssemblyDefinition assembly;
        string typesinmod = "";
        public frmMain()
        {
            InitializeComponent();
        }
        
        public long CurrentType = 0;
        public long CurrentMethod = 0;
        public long CurrentProperty = 0;
        public long CurrentField = 0;
        public long CurrentNamespace = 0;
        public string CurrentUnicodeType = "T";
        public string CurrentUnicodeMethod = "\0";
        public string CurrentUnicodeProperty = "\0";
        public string CurrentUnicodeField = "\0";
        public string CurrentUnicodeNamespace = "•";
        private Dictionary<string, string> _resourcesMapping = new Dictionary<string, string>();

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            typesinmod = "";
            OpenFileDialog o = new OpenFileDialog();
            o.Title = "Open .NET Assembly";
            o.Filter = "Executables|*.exe|Library|*.dll";
            if (o.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            try
            {
               MessageBox.Show(o.FileName);
               Assembly a = Assembly.LoadFile(o.FileName);
            }
            catch
            {
                MessageBox.Show("The file is not a .NET assembly!", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            
            
            textBox1.Text = o.FileName;
            FileVersionInfo f = FileVersionInfo.GetVersionInfo(textBox1.Text);
            textBox5.Text = "";
            textBox5.Text = "Product Name: " + f.ProductName + Environment.NewLine + "Company Name: " + f.CompanyName + Environment.NewLine + "Version: " + f.ProductVersion + Environment.NewLine + "Copyright: " + f.LegalCopyright + Environment.NewLine + "Description: " + f.FileDescription;
            assembly = AssemblyFactory.GetAssembly(textBox1.Text);
            foreach (TypeDefinition type in assembly.MainModule.Types)
            {
                string[] str = new string[11];
                str[0] = "MyApplication";
                str[1] = "MyComputer";
                str[2] = "MyProject";
                str[3] = "MyForms";
                str[4] = "MyWebServices";
                str[5] = "ThreadSafeObjectProvider";
                str[6] = "MySettings";
                str[7] = "MySettingsProperty";
                if (type.Name == "<Module>")
                    goto Label_Pie;

                if (type.IsRuntimeSpecialName)
                    goto Label_Pie;

                if (type.IsInterface)
                    goto Label_Pie;

                if (type.IsSpecialName)
                    goto Label_Pie;

                if (type.IsSpecialName)
                    goto Label_Pie;

                if (type.Name.StartsWith("<")) // Like "<PrivateImplementationDetails>"
                    goto Label_Pie;

                if (type.Name.Contains("__"))
                    goto Label_Pie;

                if (type.Name.Contains("Resources"))
                    goto Label_Pie;

                for (int i = 0; i <= 8 - 1; i++)
                {
                    if (i == 5)
                    {
                        if(type.Name.Contains(str[5]))
                        {
                            goto Label_Pie;
                        }
                    }
                    else
                    {
                        if (type.Name == str[i])
                        {
                            goto Label_Pie;
                        }
                    }
                Label_End:
                    string std;
                }
                checkedListBox1.Items.Add(type.Name);
            Label_Pie:
                string stdd;
            }
        }
                    
        private void button2_Click(object sender, EventArgs e)
        {
            if (assembly == null)
                return;

           // try
            //{
                SaveFileDialog s = new SaveFileDialog();
                s.Title = "Save Obfuscated File";
                s.Filter = "Executables|*.exe|Library|*.dll";
                if (s.ShowDialog() != DialogResult.OK)
                    return;
                if (File.Exists(s.FileName))
                    File.Delete(s.FileName);
                for (int i = 0; i <= checkedListBox1.CheckedItems.Count - 1; i++)
                {
                    typesinmod += checkedListBox1.CheckedItems[i].ToString() + "|";
                }
                foreach (ModuleDefinition module in assembly.Modules)
                    module.FullLoad();
                progressBar1.Value += 50;
                foreach (TypeDefinition type in assembly.MainModule.Types)
                {
                    ObfuscateType(type);
                }
                if (checkBox3.Checked)
                {
                    foreach (Resource resource in assembly.MainModule.Resources)
                    {
                        ObfuscateResource(resource);
                    }
                }
                _resourcesMapping.Clear();
        CurrentType = 0;
        CurrentMethod = 0;
        CurrentProperty = 0;
        CurrentField = 0;
        CurrentNamespace = 0;
        CurrentUnicodeType = "T";
       CurrentUnicodeMethod = "\0";
        CurrentUnicodeProperty = "\0";
        CurrentUnicodeField = "\0";
        CurrentUnicodeNamespace = "•";
                AssemblyFactory.SaveAssembly(assembly, s.FileName);
                progressBar1.Value += 50;
                progressBar1.Value = 0;
                MessageBox.Show("Obfuscating was successful!\n\nSaved to: " + s.FileName, "Darkfuscator v1.03", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
           //catch(Exception ex)
            //{
                //MessageBox.Show("An error occured!\n\nMessage: " + ex.Message, "Darkfuscator 1.03", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        public void ObfuscateType(TypeDefinition type)
        {

                if (type.Name == "<Module>")
                    return;

                if (type.IsRuntimeSpecialName)
                    return;

                if (type.IsSpecialName)
                    return;

                if (type.Name.StartsWith("<")) // Like "<PrivateImplementationDetails>"
                    return;

                if (type.Name.Contains("__"))
                    return;

                if (type.Name.Contains("resources"))
                    return;



               


                string name = type.FullName;
                if (typesinmod.Contains(type.Name))
                {
                    if (chkObfuscateTypes.Checked)
                    {
                        type.Name = CurrentUnicodeType;
                        CurrentUnicodeType += "T";
                        foreach (ModuleDefinition module in assembly.Modules)
                            foreach (TypeReference typeReference in module.TypeReferences)
                                if (typeReference.FullName == name)
                                    typeReference.Name = type.Name;
                    }
                    //if (checkBox2.Checked)
                    //{
                        //ObfuscateNamespace(type);
                    //}
                    //if (checkBox6.Checked)
                    //{
                        //foreach (MethodDefinition method in type.Methods)
                        //{
                            //RemoveUnused(type, method);
                        //}
                   //}
                    if (chkObfuscateMethods.Checked)
                    {
                        foreach (MethodDefinition method in type.Methods)
                        {
                            ObfuscateMethods(type, name, method);
                           
                        }
                        foreach (MethodDefinition method in type.Constructors)
                            ObfuscateParameters(type, method);

                    }
                    if (checkBox5.Checked)
                    {
                        foreach (MethodDefinition method in type.Methods)
                        {
                            ObfuscateFlow(type, method);
                        }
                    }
                    if (chkObfuscateProperties.Checked)
                    {
                        foreach (PropertyDefinition property in type.Properties)
                            ObfuscateProperty(type, property);
                    }
                    if (chkObfuscateFields.Checked)
                    {
                        foreach (FieldDefinition f in type.Fields)
                            ObfuscateFields(type, f);
                    }
                }
                
                _resourcesMapping.Add(name, type.FullName);
                
            }
        private void ObfuscateResource(Resource resource)
        {

            if (resource.Name.Contains(".Properties"))
            {
                return;
            }
            if (!resource.Name.Contains("."))
            {
                return;
            }
            string[] resourceName = resource.Name.Split('.');

            if (!_resourcesMapping.ContainsKey(resourceName[0] + "." + resourceName[1]))
                return;

            string obfucatedName = _resourcesMapping[resourceName[0] + "." + resourceName[1]];
            resource.Name = obfucatedName + ".resources";
        }
        public void ObfuscateNamespace(TypeDefinition type)
        {

            string initialNamespace = type.Namespace;
            type.Namespace = "N" + CurrentNamespace.ToString();
            CurrentNamespace++;
            foreach (ModuleDefinition module in assembly.Modules)
                foreach (TypeReference typeReference in module.TypeReferences)
                    if (typeReference.Namespace == initialNamespace)
                        typeReference.Namespace = type.Namespace;
            
        }
        public void ObfuscateFields(TypeDefinition type, FieldDefinition field)
        {
            if (field.IsRuntimeSpecialName)
                return;

            if (field.IsSpecialName)
                return;

            if (field.Name.StartsWith("<"))
            {
                return;
            }
            string initialName = field.Name;
            string str = "F";
            string obfuscatedName = str + CurrentField.ToString(); 
            foreach (MethodReference reference in MethodReference.AllReferences)
            {
                if (reference.DeclaringType.Name == type.Name &&
                    reference.DeclaringType.Namespace == type.Namespace)
                    if (!Object.ReferenceEquals(reference, field) &&
                        (reference.Name == initialName)
                        )
                    {
                        try
                        {
                            reference.Name = obfuscatedName;
                        }
                        catch (InvalidOperationException) { }
                    }

            }

            field.Name = obfuscatedName;
            CurrentField++;
        }
        public void ObfuscateMethods(TypeDefinition type, string name, MethodDefinition method)
        {
            if (method.IsConstructor)
                return;

            if (method.IsRuntime)
                return;

            if (method.IsRuntimeSpecialName)
                return;

            if (method.IsSpecialName)
                return;

            if (method.IsVirtual)
                return;

            if (method.IsAbstract)
                return;

            if (method.Overrides.Count > 0)
                return;

            if (method.Name.StartsWith("<"))
                return;
            string initialName = method.Name;
            string obfuscatedName = "M" + CurrentMethod.ToString();
            foreach (MethodReference reference in MethodReference.AllReferences)
            {
                if (reference.DeclaringType.Name == type.Name &&
                    reference.DeclaringType.Namespace == type.Namespace)
                    if (!Object.ReferenceEquals(reference, method) &&
                        reference.Name == initialName &&
                        reference.HasThis == method.HasThis &&
                        reference.CallingConvention == method.CallingConvention &&
                        reference.Parameters.Count == method.Parameters.Count &&
                        reference.GenericParameters.Count == method.GenericParameters.Count &&
                        reference.ReturnType.ReturnType.Name == method.ReturnType.ReturnType.Name &&
                        reference.ReturnType.ReturnType.Namespace == method.ReturnType.ReturnType.Namespace
                        )
                    {
                        bool paramsEquals = true;
                        for (int paramIndex = 0; paramIndex < method.Parameters.Count; paramIndex++)
                            if (reference.Parameters[paramIndex].ParameterType.FullName != method.Parameters[paramIndex].ParameterType.FullName)
                            {
                                paramsEquals = false;
                                break;
                            }

                        for (int paramIndex = 0; paramIndex < method.GenericParameters.Count; paramIndex++)
                            if (reference.GenericParameters[paramIndex].FullName != method.GenericParameters[paramIndex].FullName)
                            {
                                paramsEquals = false;
                                break;
                            }

                        try
                        {
                            if (paramsEquals)
                                reference.Name = obfuscatedName;
                        }
                        catch (InvalidOperationException) { }
                    }

            }
            method.Name = obfuscatedName;
            CurrentMethod++;

        }
        public void ObfuscateProperty(TypeDefinition type, PropertyDefinition property)
        {
            if (property.IsSpecialName)
                return;

            if (property.IsRuntimeSpecialName)
                return;
            string initialName = property.Name;
            string obfuscatedName = "PR" + CurrentProperty.ToString();
            foreach (MethodReference reference in MethodReference.AllReferences)
            {
                if (reference.DeclaringType.Name == type.Name &&
                    reference.DeclaringType.Namespace == type.Namespace)
                {
                    if (!Object.ReferenceEquals(reference, property) &&
                        (reference.Name == property.Name) &&
                        (reference.Parameters.Count == property.Parameters.Count)
                        )
                    {
                        bool paramsEquals = true;
                        for (int paramIndex = 0; paramIndex < property.Parameters.Count; paramIndex++)
                            if (reference.Parameters[paramIndex].ParameterType.FullName != property.Parameters[paramIndex].ParameterType.FullName)
                            {
                                paramsEquals = false;
                                break;
                            }

                        try
                        {
                            if (paramsEquals)
                                reference.Name = obfuscatedName;
                        }
                        catch (InvalidOperationException) { }
                    }
                }
            }
            property.Name = obfuscatedName;
            CurrentProperty++;
        }
        public void ObfuscateParameters(TypeDefinition type, MethodDefinition method)
        {
            if (type.FullName == "<Module>")
            {
                return;
            }
            string obfuscatedName = CurrentUnicodeMethod;
            foreach (ParameterReference reference in method.Parameters)
            {
                reference.Name = obfuscatedName;
            }
            CurrentMethod++;
            string obfuscatedName2 = "P" + CurrentMethod.ToString();
            foreach (GenericParameter parameter in method.GenericParameters)
            {
                parameter.Name = obfuscatedName2;
            }

            CurrentUnicodeMethod += "\0";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            frmAbout a = new frmAbout();
            a.ShowDialog();
        }
        public void RemoveUnused(TypeDefinition type, MethodDefinition method)
        {
            if (method.IsConstructor)
                return;

            if (method.IsRuntime)
                return;

            if (method.IsRuntimeSpecialName)
                return;

            if (method.IsSpecialName)
                return;

            if (method.IsVirtual)
                return;

            if (method.IsAbstract)
                return;

            if (method.Overrides.Count > 0)
                return;

            if (method.Name.StartsWith("<"))
                return;

            if (method.Body == null)
                return;

            if (method.Name.Contains("Dispose"))
                return;

            if (method.Name.Contains("ctor"))
                return;

            int count = method.Body.Instructions.Count - 1;

            if (count == 0)
            {
                type.Methods.Remove(method);
            }
        }
        public void ObfuscateFlow(TypeDefinition type, MethodDefinition method)
        {
            if (method.IsConstructor)
                return;
            
            if (method.IsRuntime)
                return;

            if (method.IsRuntimeSpecialName)
                return;

            if (method.IsSpecialName)
                return;

            if (method.IsVirtual)
                return;

            if (method.IsAbstract)
                return;

            if (method.Overrides.Count > 0)
                return;

            if (method.Name.StartsWith("<"))
                return;

            if (method.Body == null)
                return;

            if (method.Name.Contains("Dispose"))
                return;

            if (method.Name.Contains("ctor"))
                return;
            
            int count = method.Body.Instructions.Count - 1;

            if (count <= 1)
                return;

            CilWorker worker = method.Body.CilWorker;

            //Instruction insertSentencess = worker.Create(OpCodes.Testy);
            //method.Body.CilWorker.InsertAfter(method.Body.Instructions[0], insertSentencess);

            //Instruction insertSentencesss = worker.Create(OpCodes.Br_S, method.Body.Instructions[2]);
            //method.Body.CilWorker.InsertBefore(method.Body.Instructions[1], insertSentencesss);
            //Instruction redirect22 = worker.Create(OpCodes.Ret);
            //method.Body.CilWorker.InsertAfter(method.Body.Instructions[method.Body.Instructions.Count - 1], redirect22);
            List<Instruction> collection = new List<Instruction>();
            //string collection2 = String.Empty;

            foreach (Instruction i in method.Body.Instructions)
            {
                collection.Add(i);
            }

            foreach (Instruction i in collection)
            {
                method.Body.Instructions.Remove(i);
            }

            method.Body.CilWorker.Append(collection[0]);
            for (int i = 1; i < collection.Count - 1; i ++ )
            {
                int position = r.Next(0, method.Body.Instructions.Count - 1);
                method.Body.CilWorker.InsertAfter(method.Body.Instructions[position], collection[i]);
            }

            int lastpos = 0;
            Instruction redirect = worker.Create(OpCodes.Br_S, method.Body.Instructions[method.Body.Instructions.IndexOf(collection[0]) + 1]);
            method.Body.CilWorker.InsertBefore(method.Body.Instructions[0], redirect);
            lastpos = method.Body.Instructions.IndexOf(collection[0]);

            for(int i = 1; i < collection.Count - 1; i++)
            {
                //try
                //{
                    int track = 0;
                    if (lastpos < method.Body.Instructions.IndexOf(collection[i]))
                        track += 1;
                    //Instruction blank = worker.Create(OpCodes.Nop);
                    //method.Body.CilWorker.InsertBefore(method.Body.Instructions[lastpos + 1], blank);
                    Instruction redirect2 = worker.Create(OpCodes.Br_S, method.Body.Instructions[method.Body.Instructions.IndexOf(collection[i]) + track]);
                    //method.Body.CilWorker.Remove(method.Body.Instructions[lastpos + 1]);
                    method.Body.CilWorker.InsertBefore(method.Body.Instructions[lastpos + 1], redirect2);
                    lastpos = method.Body.Instructions.IndexOf(collection[i]);
                //}
                //catch
                //{
                //    MessageBox.Show("Error");
                //}
            }
            //Instruction redirect2 = worker.Create(OpCodes.Br_S, method.Body.Instructions[method.Body.Instructions.IndexOf(i)]);
            //method.Body.CilWorker.InsertAfter(method.Body.Instructions[lastpos], redirect2);
            //Instruction in1 = worker.Create(OpCodes.Br_S, method.Body.Instructions[2]);
            //method.Body.CilWorker.InsertAfter(method.Body.Instructions[1], in1);

            //Instruction in2 = worker.Create(OpCodes.Ldstr, "ajsndjkasndjknaskjdn");
            //method.Body.CilWorker.InsertAfter(method.Body.Instructions[1], in2);

            //Instruction in3 = worker.Create(OpCodes.Br_S, method.Body.Instructions[3]);
            //method.Body.CilWorker.InsertAfter(method.Body.Instructions[1], in3);

            //Instruction in4 = worker.Create(OpCodes.Ldstr, "ajsndjkasndjknaskjdn");
            //method.Body.CilWorker.InsertAfter(method.Body.Instructions[1], in4);

            //Instruction in5 = worker.Create(OpCodes.Br_S, method.Body.Instructions[3]);
            //method.Body.CilWorker.InsertAfter(method.Body.Instructions[1], in5);

            //Instruction in6 = worker.Create(OpCodes.Ldstr, "ajsndjkasndjknaskjdn");
            //method.Body.CilWorker.InsertAfter(method.Body.Instructions[1], in6);

            //Instruction in7 = worker.Create(OpCodes.Br_S, method.Body.Instructions[5]);
            //method.Body.CilWorker.InsertAfter(method.Body.Instructions[1], in7);
        }
    }

}