using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Декодер_Метео_Файлов;

namespace Meteo_decode
{
    public partial class fMeteoDecode : Form
    {   
        /**
         * Глобальные переменные
         */
        int vCount = 1; // Счетчик таймера

        public fMeteoDecode()
        {
            InitializeComponent();
        }

        // Метод вызывается при загрузке формы.
        // Записываю в текст боксы из файла настроек ранее сохраненные пути к исходному файлу и целефому файлу
        private void fMeteoDecode_Load(object sender, EventArgs e)
        {
            // Восстанавливаю сохраненые значения в textBox 1, 2 и checkBox1, 2 
            tSourceFile.Text = PropStorage.GetStrValue("SourcePath"); // Последний элемент массива "Новый текстовый документ.txt"
            tEntryFile.Text = cbNewFileInFolder.Checked ?
                PropStorage.GetStrValue("EntryPath") :
                PropStorage.GetStrValue("EntryFilePath");
            cbOpenSourceFile.Checked = PropStorage.GetBoolValue("SourceCheck");
            cbOpenEntryFile.Checked = PropStorage.GetBoolValue("EntryCheck");
            cbNewFileInFolder.Checked = PropStorage.GetBoolValue("NewFileDesktop");
        }

        // Таймер выполнения программы, должен парралельно выполнению процесса декодирования обновлять состояние UI программы
        private void tWorkApp_Tick(object sender, EventArgs e)
        {

            if (vCount > 2)
            {
                vCount = 1;
            }
            else
            {
                vCount++;
            }

            string sTmp = "Выполняется" + new string('.', vCount);

            this.Text = sTmp;
            lProgress.Text = sTmp;
        }


        // Кнопка задания даты "Сегодня"
        private void bToDay_Click(object sender, EventArgs e)
        {
            dtElem.Text = DateTime.Now.ToLongTimeString();
        }

        // Кнопка задания пути к исходному файлу
        private void bSetSourceFile_Click(object sender, EventArgs e)
        {
            string sourceFileName = FileStorage.GetFileName("Text files|*.txt");
            PropStorage.SetValue("SourcePath", sourceFileName);
            tSourceFile.Text = PropStorage.GetStrValue("SourcePath");  // Последний элемент массива "Новый текстовый документ.txt"
        }

        // Кнопка задания пути к целевому файлу
        private void bSetEntryFile_Click(object sender, EventArgs e)
        {
            if (cbNewFileInFolder.Checked)
            {
                string targetFolderName = FileStorage.GetFolderName();
                PropStorage.SetValue("EntryPath", targetFolderName);
                tEntryFile.Text = PropStorage.GetStrValue("EntryPath"); 
            }
            else
            {
                string targetFileName = FileStorage.GetFileName("Excel files|*.xlsx");
                PropStorage.SetValue("EntryFilePath", targetFileName);
                tEntryFile.Text = PropStorage.GetStrValue("EntryFilePath"); 
            }
        }

        // Чек-бокс "Открыть исходный файл"
        private void cbOpenSourceFile_CheckedChanged(object sender, EventArgs e)
        {
            PropStorage.SetValue("SourceCheck", cbOpenSourceFile.Checked);
        }

        // Чек-бокс "Открыть файл отчета"
        private void cbOpenEntryFile_CheckedChanged(object sender, EventArgs e)
        {
            PropStorage.SetValue("EntryCheck", cbOpenEntryFile.Checked);
        }

        // Чек-бокс "Создавать новый файл в указанной директории"
        private void cbNewFileInFolder_CheckedChanged(object sender, EventArgs e)
        {
            lEntryFile.Text = cbNewFileInFolder.Checked ? "Директория:" : "Целевой файл:";
            tEntryFile.Text = cbNewFileInFolder.Checked ? PropStorage.GetStrValue("EntryPath") : PropStorage.GetStrValue("EntryFilePath") ;
            PropStorage.SetValue("NewFileDesktop", cbNewFileInFolder.Checked);
        }

        // Получить пустой шаблон с переменными
        private void bGetTemplate_Click(object sender, EventArgs e)
        {

        }

        // Загрузить шаблон с переменными
        private void bDownTemplate_Click(object sender, EventArgs e)
        {
            string template = FileStorage.GetFileName("Excel files|*.xlsx");
        }

        //Метод декодирования
        private void bDecode_Click(object sender, EventArgs e)
        {
            tWorkApp.Enabled = true;
        }

        // Метод установки прогноза
        private void bPrognose_Click(object sender, EventArgs e)
        {
            fPrognose Prognose = new fPrognose();
            Prognose.Show();
        }
    }
}
