using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtBoxPath.Text = dialog.FileName;
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            clearContents();

            //UseFileStream_Read();
            //UseStreamReader();
            UseFileStream_ReadAsync();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // TODO
            //UseFileStream_Write()
            // UseStreamWriter();
            UseFileStream_WriteAsync();
        }

        private void UseFileStream_Read()
        {
            using (FileStream fileStream = new FileStream(txtBoxPath.Text, FileMode.Open))
            {
                byte[] bytes = new byte[512];
                while (fileStream.Read(bytes, 0, bytes.Count()) != 0)
                {
                    ASCIIEncoding encoder = new ASCIIEncoding();
                    txtBoxContent.Text += encoder.GetString(bytes);
                }
            }
        }

        private void UseStreamReader()
        {
            StreamReader reader = new StreamReader(txtBoxPath.Text);
            txtBoxContent.Text = reader.ReadToEnd();
            reader.Close();
            reader.Dispose();
        }

        private void clearContents()
        {
            txtBoxContent.Text = "";
        }


        private void UseFileStream_Write()
        {

            using (FileStream stream = new FileStream(txtBoxPath.Text, FileMode.Truncate))
            {
                ASCIIEncoding encoder = new ASCIIEncoding();
                byte[] bytes = encoder.GetBytes(txtBoxContent.Text);
                stream.Write(bytes, 0, bytes.Count());
            }

        }

        private void UseStreamWriter()
        {
            StreamWriter writer = new StreamWriter(txtBoxPath.Text);
            writer.WriteLine(txtBoxContent.Text);
            writer.Close();
            writer.Dispose();
        }

        private async void UseFileStream_ReadAsync()
        {

            using (FileStream fileStream = new FileStream(txtBoxPath.Text, FileMode.Open))
            {
                byte[] bytes = new byte[512];
                while (await fileStream.ReadAsync(bytes, 0, bytes.Count()) != 0)
                {
                    ASCIIEncoding encoder = new ASCIIEncoding();
                    txtBoxContent.Text += encoder.GetString(bytes);
                }
            }

        }

        private void UseFileStream_WriteAsync()
        {

            using (FileStream stream = new FileStream(txtBoxPath.Text, FileMode.Truncate))
            {
                ASCIIEncoding encoder = new ASCIIEncoding();
                byte[] bytes = encoder.GetBytes(txtBoxContent.Text);
                stream.WriteAsync(bytes, 0, bytes.Count());
            }

        }

        private void btnFolderBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = folderDialog.SelectedPath;
            }
        }

        /// <summary>
        /// Show Files and Folders in listboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowFilesAndFolder_Click(object sender, EventArgs e)
        {
            RefreshAndLoad();
        }

        private void RefreshAndLoad()
        {
            ClearListBoxes();
            List<string> files = Directory.GetFiles(txtFolderPath.Text).ToList();
            files.ForEach(file => listBoxFiles.Items.Add(file));

            List<string> folders = Directory.GetDirectories(txtFolderPath.Text).ToList();
            folders.ForEach(folder => listBoxFolders.Items.Add(folder));
        }

        private void ClearListBoxes()
        {
            listBoxFiles.Items.Clear();
            listBoxFolders.Items.Clear();
        }

        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedIndex == -1) return;

            FileInfo fileInfo = new FileInfo(listBoxFiles.SelectedItem as string);
            
            lblFileInfo.Text = fileInfo.LastAccessTime.ToString();
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.Combine(txtFolderPath.Text, "CodeGenerated"));
            RefreshAndLoad();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }






    }
}
