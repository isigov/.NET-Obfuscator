using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Security.Cryptography;
using Microsoft.Win32;

namespace Darkfuscator
{
    public partial class frmLicense : Form
    {
        public frmLicense()
        {
            InitializeComponent();
        }

        private string getVolumeSerial(string drive)
        {
            ManagementObject disk = new ManagementObject(@"win32_logicaldisk.deviceid=""" + drive + @":""");
            disk.Get();

            string volumeSerial = disk["VolumeSerialNumber"].ToString();
            disk.Dispose();

            return volumeSerial;
        }

        private string getCPUID()
        {
            string cpuInfo = "";
            ManagementClass managClass = new ManagementClass("win32_processor");
            ManagementObjectCollection managCollec = managClass.GetInstances();

            foreach (ManagementObject managObj in managCollec)
            {
                if (cpuInfo == "")
                {
                    cpuInfo = managObj.Properties["processorID"].Value.ToString();
                    break;
                }
            }

            return cpuInfo;
        }
        private string getUniqueID(string drive)
        {
            if (drive == string.Empty)
            {
                foreach (DriveInfo compDrive in DriveInfo.GetDrives())
                {
                    if (compDrive.IsReady)
                    {
                        drive = compDrive.RootDirectory.ToString();
                        break;
                    }
                }
            }

            if (drive.EndsWith(":\\"))
            {
                drive = drive.Substring(0, drive.Length - 2);
            }

            string volumeSerial = getVolumeSerial(drive);
            string cpuID = getCPUID();

            return cpuID.Substring(13) + cpuID.Substring(1, 4) + volumeSerial + cpuID.Substring(4, 4);
        }

        private void frmLicense_Load(object sender, EventArgs e)
        {
            string str5 = "";
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Darkfuscator 1.00");
                 str5 = (string)key.GetValue("Confirmation ID");
                key.Close();
            }
            catch
            {

            }
            string str = getUniqueID("C");
            string final = "";
            for (int i = 0; i <= 3; i++)
            {
                string str3 = str.Substring(0, 4);
                final += str3 + "-";
                str = str.Replace(str3, "");
            }
            textBox1.Text = final + str + "W";
            if (DecryptString(str5, "AppleNo123") == textBox1.Text)
            {
                frmMain m = new frmMain();
                this.Opacity = 0;
                this.ShowInTaskbar = false;
                m.ShowDialog();
                Environment.Exit(0);
            }
        }
        static string EncryptString(string clearText, string Password)
        {
            byte[] clearBytes =
              System.Text.Encoding.Unicode.GetBytes(clearText);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
            byte[] encryptedData = EncryptByte(clearBytes,
                     pdb.GetBytes(32), pdb.GetBytes(16));
            return Convert.ToBase64String(encryptedData);
        }

        static byte[] EncryptByte(byte[] clearData, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;
            CryptoStream cs = new CryptoStream(ms,
               alg.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(clearData, 0, clearData.Length);
            cs.Close();
            byte[] encryptedData = ms.ToArray();
            return encryptedData;
        }
        static byte[] DecryptByte(byte[] cipherData, byte[] Key, byte[] IV)
        {

            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;
            CryptoStream cs = new CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(cipherData, 0, cipherData.Length);
            cs.Close();
            byte[] decryptedData = ms.ToArray();
            return decryptedData;

        }
        static string DecryptString(string cipherText, string Password)
        {
            try
            {
                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                    new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 
            0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
                byte[] decryptedData = DecryptByte(cipherBytes,
                    pdb.GetBytes(32), pdb.GetBytes(16));
                return System.Text.Encoding.Unicode.GetString(decryptedData);
            }
            catch
            {
                return "error";
            }
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            if (DecryptString(textBox2.Text, "AppleNo123") == textBox1.Text)
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Darkfuscator 1.00");
                key.SetValue("Confirmation ID", textBox2.Text);
                key.Close();
                MessageBox.Show("You have been successfully activated!\n\nThanks for purchasing Darkfuscator!", "Darkfuscator 1.00", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Restart the application!", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("Activation was unsuccessful!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
