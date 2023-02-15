using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWshRuntimeLibrary; //vs側でwindows script hostを参照する (未実行)
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

        private void shortcutCreater()
        {
            String path = shortcutPath.Text + "\\osu!.exe";

        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            shortcutPath.Text = filePathSelector();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(shortcutPath.Text.Length != 0 && connectServer.Text.Length != 0)
            {
                
            } else
            {
                MessageBox.Show("入力値が不足しています!", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
