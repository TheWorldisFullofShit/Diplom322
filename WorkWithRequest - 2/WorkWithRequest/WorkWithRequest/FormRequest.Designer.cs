namespace WorkWithRequest
{
    partial class FormRequest
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.textBoxDes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.typeOfRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemRequestsDataSet = new WorkWithRequest.SystemRequestsDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.заявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправитToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполненныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.невыполненныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вПроцессеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientsTableAdapter = new WorkWithRequest.SystemRequestsDataSetTableAdapters.ClientsTableAdapter();
            this.typeOfRequestTableAdapter = new WorkWithRequest.SystemRequestsDataSetTableAdapters.TypeOfRequestTableAdapter();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.typeOfStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeOfStatusTableAdapter = new WorkWithRequest.SystemRequestsDataSetTableAdapters.TypeOfStatusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfRequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemRequestsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(108, 144);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(366, 53);
            this.textBoxData.TabIndex = 9;
            // 
            // textBoxDes
            // 
            this.textBoxDes.Location = new System.Drawing.Point(78, 84);
            this.textBoxDes.Multiline = true;
            this.textBoxDes.Name = "textBoxDes";
            this.textBoxDes.Size = new System.Drawing.Size(396, 54);
            this.textBoxDes.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Дополнительно:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Описание:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DataSource = this.typeOfRequestBindingSource;
            this.comboBoxType.DisplayMember = "NameType";
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(47, 57);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(427, 21);
            this.comboBoxType.TabIndex = 5;
            this.comboBoxType.ValueMember = "IdType";
            // 
            // typeOfRequestBindingSource
            // 
            this.typeOfRequestBindingSource.DataMember = "TypeOfRequest";
            this.typeOfRequestBindingSource.DataSource = this.systemRequestsDataSet;
            // 
            // systemRequestsDataSet
            // 
            this.systemRequestsDataSet.DataSetName = "SystemRequestsDataSet";
            this.systemRequestsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип:";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.DataSource = this.clientsBindingSource;
            this.comboBoxClient.DisplayMember = "FIO";
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(64, 30);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(410, 21);
            this.comboBoxClient.TabIndex = 3;
            this.comboBoxClient.ValueMember = "IdClient";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.systemRequestsDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Клиент:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заявкиToolStripMenuItem,
            this.отчётToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // заявкиToolStripMenuItem
            // 
            this.заявкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.отправитToolStripMenuItem,
            this.статусToolStripMenuItem});
            this.заявкиToolStripMenuItem.Name = "заявкиToolStripMenuItem";
            this.заявкиToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.заявкиToolStripMenuItem.Text = "Заявки";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // отправитToolStripMenuItem
            // 
            this.отправитToolStripMenuItem.Name = "отправитToolStripMenuItem";
            this.отправитToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.отправитToolStripMenuItem.Text = "Отправить";
            this.отправитToolStripMenuItem.Click += new System.EventHandler(this.отправитToolStripMenuItem_Click);
            // 
            // статусToolStripMenuItem
            // 
            this.статусToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выполненныеToolStripMenuItem,
            this.невыполненныеToolStripMenuItem,
            this.вПроцессеToolStripMenuItem,
            this.всеToolStripMenuItem});
            this.статусToolStripMenuItem.Name = "статусToolStripMenuItem";
            this.статусToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.статусToolStripMenuItem.Text = "Статус";
            // 
            // выполненныеToolStripMenuItem
            // 
            this.выполненныеToolStripMenuItem.Name = "выполненныеToolStripMenuItem";
            this.выполненныеToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.выполненныеToolStripMenuItem.Text = "Выполненные";
            this.выполненныеToolStripMenuItem.Click += new System.EventHandler(this.выполненныеToolStripMenuItem_Click);
            // 
            // невыполненныеToolStripMenuItem
            // 
            this.невыполненныеToolStripMenuItem.Name = "невыполненныеToolStripMenuItem";
            this.невыполненныеToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.невыполненныеToolStripMenuItem.Text = "Невыполненные";
            this.невыполненныеToolStripMenuItem.Click += new System.EventHandler(this.невыполненныеToolStripMenuItem_Click);
            // 
            // вПроцессеToolStripMenuItem
            // 
            this.вПроцессеToolStripMenuItem.Name = "вПроцессеToolStripMenuItem";
            this.вПроцессеToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.вПроцессеToolStripMenuItem.Text = "В процессе";
            this.вПроцессеToolStripMenuItem.Click += new System.EventHandler(this.вПроцессеToolStripMenuItem_Click);
            // 
            // всеToolStripMenuItem
            // 
            this.всеToolStripMenuItem.Name = "всеToolStripMenuItem";
            this.всеToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.всеToolStripMenuItem.Text = "Все";
            this.всеToolStripMenuItem.Click += new System.EventHandler(this.всеToolStripMenuItem_Click);
            // 
            // отчётToolStripMenuItem
            // 
            this.отчётToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.экспортВExcelToolStripMenuItem});
            this.отчётToolStripMenuItem.Name = "отчётToolStripMenuItem";
            this.отчётToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчётToolStripMenuItem.Text = "Отчёт";
            // 
            // экспортВExcelToolStripMenuItem
            // 
            this.экспортВExcelToolStripMenuItem.Name = "экспортВExcelToolStripMenuItem";
            this.экспортВExcelToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.экспортВExcelToolStripMenuItem.Text = "Экспорт в Excel";
            this.экспортВExcelToolStripMenuItem.Click += new System.EventHandler(this.экспортВExcelToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(480, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 231);
            this.dataGridView1.TabIndex = 13;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // typeOfRequestTableAdapter
            // 
            this.typeOfRequestTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Статус:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.typeOfStatusBindingSource;
            this.comboBox1.DisplayMember = "NameStatus";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(412, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "IdStatus";
            // 
            // typeOfStatusBindingSource
            // 
            this.typeOfStatusBindingSource.DataMember = "TypeOfStatus";
            this.typeOfStatusBindingSource.DataSource = this.systemRequestsDataSet;
            // 
            // typeOfStatusTableAdapter
            // 
            this.typeOfStatusTableAdapter.ClearBeforeFill = true;
            // 
            // FormRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 473);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.textBoxDes);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormRequest";
            this.Text = "Работа с заявками";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typeOfRequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemRequestsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfStatusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem заявкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отправитToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статусToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполненныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem невыполненныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SystemRequestsDataSet systemRequestsDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private SystemRequestsDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource typeOfRequestBindingSource;
        private SystemRequestsDataSetTableAdapters.TypeOfRequestTableAdapter typeOfRequestTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem вПроцессеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортВExcelToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.BindingSource typeOfStatusBindingSource;
        private SystemRequestsDataSetTableAdapters.TypeOfStatusTableAdapter typeOfStatusTableAdapter;
    }
}

