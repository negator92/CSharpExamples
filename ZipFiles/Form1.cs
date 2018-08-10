using Ionic.Zip;
using System.Windows.Forms;

namespace ZipFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        private void button1_Click(object sender, BindingCompleteEventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;
            textBox1.Text = folderBrowserDialog.SelectedPath;
        }


        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Zip files (*.zip)|*.zip";
            if (textBox1.Text == "" && saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            ZipFile zipFile = new ZipFile(saveFileDialog.FileName);
            zipFile.AddDirectory(folderBrowserDialog.SelectedPath);
            zipFile.Save();
            MessageBox.Show("Success archivating.", "Done");
        }

        private void folderBrowserDialog1_HelpRequest(object sender, System.EventArgs e)
        {

        }
    }
}