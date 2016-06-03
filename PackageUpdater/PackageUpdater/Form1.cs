using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PackageUpdater
{
    /*
     * приложение для работы с пакетами обновлений.
     * Суть приложения:
     * 1) Выбор папки с исходными файлами.
     * 2) Показать список исходных файлов с их расширением.
     * 3) Сделать функцию выбора расширении для удаления файлов по ним.
     * 4) Сделать выбор даты, для удаления по дате создания файла.
     * 5) Сделать Сохранение файлов в архивном виде в указанную директорию.
     */
    public partial class Form1 : Form
    {
        //создать структуру для выбора и фильтрации требуемых файлов
        //создать структуру файлов для удаления данных
        public Form1()
        {
            InitializeComponent();
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                string[] files = Directory.GetFiles(fbd.SelectedPath);

               // System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");

            }
        }

        //обработка выбранной директории, и агрегации таблицы
        private void DiscoveryFolder(string directoryPath)
        {
 
        }

        private void saveToFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //удаление 
        private void toolStripButtonRemoveByExt_Click(object sender, EventArgs e)
        {

        }

        //https://msdn.microsoft.com/en-us/library/ms404280%28v=vs.110%29.aspx
        //http://stackoverflow.com/questions/17232414/creating-a-zip-archive-in-memory-using-system-io-compression

        static string directoryPath = "";
        //архивация данных
        private void Compress(DirectoryInfo directorySelected)
        {
            foreach (FileInfo fileToCompress in directorySelected.GetFiles())
            {
                using (FileStream originalFileStream = fileToCompress.OpenRead())
                {
                    if ((File.GetAttributes(fileToCompress.FullName) & 
                       FileAttributes.Hidden) != FileAttributes.Hidden & fileToCompress.Extension != ".gz")
                    {
                        using (FileStream compressedFileStream = File.Create(fileToCompress.FullName + ".gz"))
                        {
                            using (GZipStream compressionStream = new GZipStream(compressedFileStream, 
                               CompressionMode.Compress))
                            {
                                originalFileStream.CopyTo(compressionStream);

                            }
                        }
                        FileInfo info = new FileInfo(directoryPath + "\\" + fileToCompress.Name + ".gz");
                        Console.WriteLine("Compressed {0} from {1} to {2} bytes.",
                        fileToCompress.Name, fileToCompress.Length.ToString(), info.Length.ToString());
                    }

                }
            }
        }

        private void Remove(DirectoryInfo directorySelected)
        {
 
        }


    }
}
