using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Декодер_Метео_Файлов
{
    // Класс для работы с файлами
    class FileStorage
    {
        /* Метод открывает диалоговое окно для выбора файла с использованием фильтра файлов (param)
         * "Text files|*.txt"
         * "Excel files|*.xlsx"
         */
        public static string GetFileName(string param)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            ofd.Filter = param;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }
            else
            {
                return "";
            }
        }
        // Метод открывает диалоговое окно для выбора директории
        public static string GetFolderName()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                return fbd.SelectedPath;
            }
            else
            {
                return "";
            }
        }

        // Метод проверяет используется ли файл во время выполнения программы
        public static bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
        }

        // Метод чтения файла. Принимает аргументом путь к исходному файлу
        public static string[] ReadFile(string path)
        {
            // Сохраняю в виде одной строки весь документ
            string document = File.ReadAllText(path, Encoding.Default);

            // С помощью метода Replace удаляю все переводы на новую строку 
            Regex RegExp = new Regex(@"\n");
            document = RegExp.Replace(document, "");

            // С помощью метода Split документ преобразую в массив строк по разделителю '=' и возвращяю его.
            //RegExp = new Regex("=");
            string[] incomplete = new Regex("=").Split(document);
            for (int i = 0; i < incomplete.Length; i++)
            {
                incomplete[i] += "=";
            }
            return incomplete;
        }

        // Данный метод определяет как будет называться файл в указанной директории
        public static string GetNewFileName(string PathDirectory, string FileName)
        {
            string[] allfiles = Directory.GetFiles(PathDirectory);

            int i = 0;

            foreach (string filename in allfiles)
            {
                if (filename.Contains(PathDirectory + FileName))
                {
                    i++;
                }
            }

            if (i > 0)
            {
                return PathDirectory + FileName + " (" + i + ").xlsx";
            }
            else
            {
                return PathDirectory + FileName + ".xlsx";
            }
        }
    }
}

