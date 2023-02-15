using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace mamestagram_patcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private String filePathSelector()
        {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();

            if(fbDialog.ShowDialog() == DialogResult.OK)
            {
                fbDialog.Dispose();

                return fbDialog.SelectedPath;
            } else
            {
                return null;
            }
        }

        private void ServerConnecter()
        {
            String path = shortcutPath.Text + "\\osu!.exe";
            ProcessStartInfo processStartInfo = new ProcessStartInfo(path, " -devserver " + connectServer.Text);

            Process.Start(processStartInfo);
            Close();
        }

        private void DataSaver()
        {
            if (cbAddress.Checked)
            {
                StreamWriter writePath= new StreamWriter("data\\path.log", false, System.Text.Encoding.GetEncoding("UTF-8"));

                writePath.Write(shortcutPath.Text);
                writePath.Close();
            }
            else
            {
                StreamWriter writePath= new StreamWriter("data\\path.log", false, System.Text.Encoding.GetEncoding("UTF-8"));
               
                writePath.Write("");
                writePath.Close();
            }

            if (cbSavePath.Checked)
            {
                StreamWriter writeAddress = new StreamWriter("data\\address.log", false ,System.Text.Encoding.GetEncoding("UTF-8"));
                
                writeAddress.Write(connectServer.Text);
                writeAddress.Close();
            }else
            {
                StreamWriter writeAddress = new StreamWriter("data\\address.log", false ,System.Text.Encoding.GetEncoding("UTF-8"));
                
                writeAddress.Write("");
                writeAddress.Close();
            }
        }

        private void DataLoader()
        {
            String path = "";
            String address = "";
            
            if (!Directory.Exists("data"))
            {
                Directory.CreateDirectory("data");

                return;
            }

            StreamReader readPath = new StreamReader("data\\path.log");
            StreamReader readAddress = new StreamReader("data\\address.log");
            
            path = readPath.ReadLine();
            address = readAddress.ReadLine();

            connectServer.Text = address;
            shortcutPath.Text = path;

            if (address != "") cbAddress.Checked = true;
            if (path != "") cbSavePath.Checked = true;
            
            readAddress.Close();
            readPath.Close();
        }
        
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            shortcutPath.Text = filePathSelector();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(shortcutPath.Text.Length != 0 && connectServer.Text.Length != 0)
            { 
                DataSaver();
                ServerConnecter();
                Close();
            } else
            {
                MessageBox.Show("入力値が不足しています!", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataLoader();
        }
    }
}
