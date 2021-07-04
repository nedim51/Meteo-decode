
namespace Meteo_decode
{
    partial class fMeteoDecode
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMeteoDecode));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bDecode = new System.Windows.Forms.Button();
            this.lProgress = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.bGetEmptyFile = new System.Windows.Forms.Button();
            this.cbNewFileInFolder = new System.Windows.Forms.CheckBox();
            this.cbOpenEntryFile = new System.Windows.Forms.CheckBox();
            this.cbOpenSourceFile = new System.Windows.Forms.CheckBox();
            this.bToDay = new System.Windows.Forms.Button();
            this.dtElem = new System.Windows.Forms.DateTimePicker();
            this.tEntryFile = new System.Windows.Forms.TextBox();
            this.tSourceFile = new System.Windows.Forms.TextBox();
            this.lDate = new System.Windows.Forms.Label();
            this.lEntryFile = new System.Windows.Forms.Label();
            this.lSourceFile = new System.Windows.Forms.Label();
            this.tWorkApp = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bPrognose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bPrognose);
            this.groupBox1.Controls.Add(this.bDecode);
            this.groupBox1.Controls.Add(this.lProgress);
            this.groupBox1.Controls.Add(this.pb1);
            this.groupBox1.Controls.Add(this.bGetEmptyFile);
            this.groupBox1.Controls.Add(this.cbNewFileInFolder);
            this.groupBox1.Controls.Add(this.cbOpenEntryFile);
            this.groupBox1.Controls.Add(this.cbOpenSourceFile);
            this.groupBox1.Controls.Add(this.bToDay);
            this.groupBox1.Controls.Add(this.dtElem);
            this.groupBox1.Controls.Add(this.tEntryFile);
            this.groupBox1.Controls.Add(this.tSourceFile);
            this.groupBox1.Controls.Add(this.lDate);
            this.groupBox1.Controls.Add(this.lEntryFile);
            this.groupBox1.Controls.Add(this.lSourceFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Работа с файлами:";
            // 
            // bDecode
            // 
            this.bDecode.Location = new System.Drawing.Point(20, 321);
            this.bDecode.Name = "bDecode";
            this.bDecode.Size = new System.Drawing.Size(333, 36);
            this.bDecode.TabIndex = 13;
            this.bDecode.Text = "Декодировать";
            this.bDecode.UseVisualStyleBackColor = true;
            this.bDecode.Click += new System.EventHandler(this.bDecode_Click);
            // 
            // lProgress
            // 
            this.lProgress.AutoSize = true;
            this.lProgress.Location = new System.Drawing.Point(20, 242);
            this.lProgress.Name = "lProgress";
            this.lProgress.Size = new System.Drawing.Size(63, 15);
            this.lProgress.TabIndex = 12;
            this.lProgress.Text = "Прогресс:";
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(20, 260);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(333, 23);
            this.pb1.TabIndex = 11;
            // 
            // bGetEmptyFile
            // 
            this.bGetEmptyFile.AutoSize = true;
            this.bGetEmptyFile.Location = new System.Drawing.Point(20, 210);
            this.bGetEmptyFile.Name = "bGetEmptyFile";
            this.bGetEmptyFile.Size = new System.Drawing.Size(333, 26);
            this.bGetEmptyFile.TabIndex = 10;
            this.bGetEmptyFile.Text = "Получить пустой шаблон [.xlsx]";
            this.bGetEmptyFile.UseVisualStyleBackColor = true;
            // 
            // cbNewFileInFolder
            // 
            this.cbNewFileInFolder.AutoSize = true;
            this.cbNewFileInFolder.Location = new System.Drawing.Point(20, 180);
            this.cbNewFileInFolder.Name = "cbNewFileInFolder";
            this.cbNewFileInFolder.Size = new System.Drawing.Size(333, 19);
            this.cbNewFileInFolder.TabIndex = 9;
            this.cbNewFileInFolder.Text = "Формировать новый документ в указанной директории";
            this.cbNewFileInFolder.UseVisualStyleBackColor = true;
            // 
            // cbOpenEntryFile
            // 
            this.cbOpenEntryFile.AutoSize = true;
            this.cbOpenEntryFile.Location = new System.Drawing.Point(20, 150);
            this.cbOpenEntryFile.Name = "cbOpenEntryFile";
            this.cbOpenEntryFile.Size = new System.Drawing.Size(281, 19);
            this.cbOpenEntryFile.TabIndex = 8;
            this.cbOpenEntryFile.Text = "Открыть отчет по завершении декодирования";
            this.cbOpenEntryFile.UseVisualStyleBackColor = true;
            // 
            // cbOpenSourceFile
            // 
            this.cbOpenSourceFile.AutoSize = true;
            this.cbOpenSourceFile.Location = new System.Drawing.Point(20, 120);
            this.cbOpenSourceFile.Name = "cbOpenSourceFile";
            this.cbOpenSourceFile.Size = new System.Drawing.Size(162, 19);
            this.cbOpenSourceFile.TabIndex = 7;
            this.cbOpenSourceFile.Text = "Открыть исходный файл";
            this.cbOpenSourceFile.UseVisualStyleBackColor = true;
            // 
            // bToDay
            // 
            this.bToDay.Location = new System.Drawing.Point(273, 84);
            this.bToDay.Name = "bToDay";
            this.bToDay.Size = new System.Drawing.Size(80, 23);
            this.bToDay.TabIndex = 6;
            this.bToDay.Text = "Сегодня";
            this.bToDay.UseVisualStyleBackColor = true;
            // 
            // dtElem
            // 
            this.dtElem.Location = new System.Drawing.Point(125, 84);
            this.dtElem.Name = "dtElem";
            this.dtElem.Size = new System.Drawing.Size(142, 23);
            this.dtElem.TabIndex = 5;
            // 
            // tEntryFile
            // 
            this.tEntryFile.Location = new System.Drawing.Point(125, 57);
            this.tEntryFile.Name = "tEntryFile";
            this.tEntryFile.Size = new System.Drawing.Size(228, 23);
            this.tEntryFile.TabIndex = 4;
            // 
            // tSourceFile
            // 
            this.tSourceFile.Location = new System.Drawing.Point(125, 27);
            this.tSourceFile.Name = "tSourceFile";
            this.tSourceFile.Size = new System.Drawing.Size(228, 23);
            this.tSourceFile.TabIndex = 3;
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(20, 90);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(35, 15);
            this.lDate.TabIndex = 2;
            this.lDate.Text = "Дата:";
            // 
            // lEntryFile
            // 
            this.lEntryFile.AutoSize = true;
            this.lEntryFile.Location = new System.Drawing.Point(20, 60);
            this.lEntryFile.Name = "lEntryFile";
            this.lEntryFile.Size = new System.Drawing.Size(90, 15);
            this.lEntryFile.TabIndex = 1;
            this.lEntryFile.Text = "Целевой файл:";
            // 
            // lSourceFile
            // 
            this.lSourceFile.AutoSize = true;
            this.lSourceFile.Location = new System.Drawing.Point(20, 30);
            this.lSourceFile.Name = "lSourceFile";
            this.lSourceFile.Size = new System.Drawing.Size(98, 15);
            this.lSourceFile.TabIndex = 0;
            this.lSourceFile.Text = "Исходный файл:";
            // 
            // tWorkApp
            // 
            this.tWorkApp.Interval = 1000;
            this.tWorkApp.Tick += new System.EventHandler(this.tWorkApp_Tick);
            // 
            // bPrognose
            // 
            this.bPrognose.AutoSize = true;
            this.bPrognose.Location = new System.Drawing.Point(20, 289);
            this.bPrognose.Name = "bPrognose";
            this.bPrognose.Size = new System.Drawing.Size(333, 26);
            this.bPrognose.TabIndex = 15;
            this.bPrognose.Text = "Задать прогноз";
            this.bPrognose.UseVisualStyleBackColor = true;
            this.bPrognose.Click += new System.EventHandler(this.bPrognose_Click);
            // 
            // fMeteoDecode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMeteoDecode";
            this.Text = "Декодер метео-файлов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bDecode;
        private System.Windows.Forms.Label lProgress;
        private System.Windows.Forms.ProgressBar pb1;
        private System.Windows.Forms.Button bGetEmptyFile;
        private System.Windows.Forms.CheckBox cbNewFileInFolder;
        private System.Windows.Forms.CheckBox cbOpenEntryFile;
        private System.Windows.Forms.CheckBox cbOpenSourceFile;
        private System.Windows.Forms.Button bToDay;
        private System.Windows.Forms.DateTimePicker dtElem;
        private System.Windows.Forms.TextBox tEntryFile;
        private System.Windows.Forms.TextBox tSourceFile;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lEntryFile;
        private System.Windows.Forms.Label lSourceFile;
        private System.Windows.Forms.Timer tWorkApp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bPrognose;
    }
}

