using System.Windows.Forms;
using ClientHomeWork2.ServiceReference1;
using System.Linq;
using System;

namespace ClientHomeWork2
{
    public partial class Form1 : Form
    {
        private FolderBrowserDialog folderBrowserDialog;
        GetDiskClient proxy = new GetDiskClient();
        string[] result;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, System.EventArgs e)
        {
            folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string foldername = folderBrowserDialog.SelectedPath;
            tbPath.Text = foldername;
            var path = foldername;
           
            try
            {
                result = proxy.GetDiskInfo(path);
                foreach (var item in result)
                {
                    if (item.Contains('.'))

                    {
                        lbFiles.Items.Add(item);

                    }
                    else
                    {
                        lbFolders.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFiles_Click(object sender, System.EventArgs e)
        {
            if (lbFiles.Items!=null)
            {
                lbFiles.Visible = true;
            }
           
        }

        private void btnFolders_Click(object sender, System.EventArgs e)
        {
            if (lbFolders.Items != null)
            {
                lbFolders.Visible = true;
            }
        }
    }
}
