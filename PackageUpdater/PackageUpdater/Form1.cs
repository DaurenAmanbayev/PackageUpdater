using System;
using System.Collections;
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
        List<string> extensionsList = new List<string>();
        static string directoryPath = "";
        bool workplaceIsClear = true;
        //создать структуру для выбора и фильтрации требуемых файлов
        //создать структуру файлов для удаления данных
        public Form1()
        {
            InitializeComponent();
        }
        //выбрать папку исходных файлов
        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                if (!workplaceIsClear)
                {
                    listViewDirectoryDetails.Items.Clear();
                    extensionsList.Clear();
                }
                DiscoveryFolder(fbd.SelectedPath);
                directoryPath = fbd.SelectedPath;
                workplaceIsClear = false;
            }
        }

        //обработка выбранной директории, и агрегации таблицы
        //можно расширить функционал для рекурсивного поиска вложенных файлов...
        private void DiscoveryFolder(string directoryPath)
        {
            string[] files = Directory.GetFiles(directoryPath);
            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);
                var item = new ListViewItem(new[] {
                        info.Name,
                        info.FullName,
                        info.CreationTimeUtc.ToString(),
                        info.Extension});
                listViewDirectoryDetails.Items.Add(item);

                AddAvailableExtension(info.Extension);
            }
           // toolStripComboBoxExtensions.ComboBox.DataSource = extensionsList;
            toolStripStatusLabelDirectoryInfo.Text = string.Format("Info: path: {0}; files count: {1}", directoryPath, files.Length);

        }
        //создания списка доступных расширений в папке
        private void AddAvailableExtension(string extension)
        {
            if (!extensionsList.Contains(extension))
            {
                extensionsList.Add(extension);                
                //toolStripDropDownButtonExtensions.DropDownItems.Add(new ToolStripDropDownButton { Text = extension,ToolTipText=extension });
            }            
        }

        //сохранить список файлов в архив
        private void saveToFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();
            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                DirectoryInfo dir = new DirectoryInfo(directoryPath);
                string zipPath=fbd.SelectedPath+"\\"+dir.Name+".zip";               
                ZipFile.CreateFromDirectory(directoryPath, zipPath);                
            }
        }

        //архивация данных в формате .Gz
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
                        MessageBox.Show(string.Format("Compressed {0} from {1} to {2} bytes.",
                        fileToCompress.Name, fileToCompress.Length.ToString(), info.Length.ToString()),"Compress");
                    }
                }
            }
        }
        //удалить файлы по расширению
        private void RemoveByExtension(List<string> checkedList)
        {
            string[] files = Directory.GetFiles(directoryPath);
            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);
                //если расширение файла имеется в списке, удалить файл
                if (checkedList.Contains(info.Extension.ToString()))
                {
                    File.Delete(info.FullName);
                }
            }
            //очищаем рабочее место, заполняем обновленными данными
            listViewDirectoryDetails.Items.Clear();
            extensionsList.Clear();
            DiscoveryFolder(directoryPath);
        }
        //удалить файлы по дате создания
        private void RemoveByDate(DateTime date)
        {
            string[] files = Directory.GetFiles(directoryPath);
            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);
                //если дата создания совпадает, с датой фильтрации, удалить файл
                if (info.CreationTimeUtc.Date == date.Date)
                {
                    File.Delete(info.FullName);
                }
            }
            //очищаем рабочее место, заполняем обновленными данными
            listViewDirectoryDetails.Items.Clear();
            extensionsList.Clear();
            DiscoveryFolder(directoryPath);
        }
        //очистить рабочее место
        private void clearWorkAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //предупреждение
            listViewDirectoryDetails.Items.Clear();
            extensionsList.Clear();
            workplaceIsClear = true;
            //toolStripComboBoxExtensions.ComboBox.DataSource = extensionsList;
        }
        //выбор списка расширений и их удаление
        private void toolStripButtonRemoveByExtension_Click(object sender, EventArgs e)
        {
            //предупреждение
            ExtensionsManager frm = new ExtensionsManager(extensionsList);
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                RemoveByExtension(frm.GetCheckedList());
            }

        }      
        //удаление по дате создания
        private void toolStripButtonRemoveByDate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что собираетесь удалить файлы в данной папке по дате создания", "Фильтр по дате", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                RemoveByDate(dateTimePickerCreated.Value);
            }
        }
    }
}
