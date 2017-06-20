using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Microsoft.Office.Interop;

namespace WorkWithRequest
{
    public partial class FormRequest : Form
    {
        NpgsqlConnection connectionString = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=12345;Database=SystemRequests");

        public FormRequest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "systemRequestsDataSet.TypeOfStatus". При необходимости она может быть перемещена или удалена.
            this.typeOfStatusTableAdapter.Fill(this.systemRequestsDataSet.TypeOfStatus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "systemRequestsDataSet.TypeOfRequest". При необходимости она может быть перемещена или удалена.
            this.typeOfRequestTableAdapter.Fill(this.systemRequestsDataSet.TypeOfRequest);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "systemRequestsDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.systemRequestsDataSet.Clients);

            AddDataToDataGrid();


            pictureBox1.ImageLocation = @"C:\\tarify-rostelekom.jpg"; // Задает путь для изображения, отображаемого в pictureBoxLogo.
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Указывает способ отображения изображения
            pictureBox1.Load();  // Отображает изображение, указанное в ImageLocation свойство pictureBoxLogo
        }

        public void AddDataToDataGrid()
        {
            DataSet dataSetRequest = new DataSet();

            connectionString.Open();

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("select \"Requests\".\"IdRequest\", \"TypeOfRequest\".\"NameType\", \"Clients\".\"FIO\", \"Requests\".\"Descriprion\",  \"Requests\".\"AdditionalInfo\", \"Requests\".\"Date\", \"TypeOfStatus\".\"NameStatus\" from \"Requests\" JOIN \"TypeOfRequest\" ON \"Requests\".\"Type\" = \"TypeOfRequest\".\"IdType\"  JOIN  \"Clients\" ON \"Requests\".\"Client\" = \"Clients\".\"IdClient\" JOIN \"TypeOfStatus\" ON \"Requests\".\"Status\" = \"TypeOfStatus\".\"IdStatus\"", connectionString);
            //dataAdapter.Fill(dataSetRequest);
            //dataGridView1.DataSource = dataSetRequest.Tables[0];
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            table.Columns["IdRequest"].ColumnName = "Номер заявки";
            table.Columns["NameType"].ColumnName = "Тип заявки";
            table.Columns["FIO"].ColumnName = "ФИО клиента";
            table.Columns["Descriprion"].ColumnName = "Описание";
            table.Columns["AdditionalInfo"].ColumnName = "Дополнительно";
            table.Columns["Date"].ColumnName = "Дата обращения";
            table.Columns["NameStatus"].ColumnName = "Статус";
            dataGridView1.DataSource = table;
            connectionString.Close();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = "";

            NpgsqlCommand com = new NpgsqlCommand("select max(\"IdRequest\") from \"Requests\"", connectionString);
            connectionString.Open();
            NpgsqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    result = reader.GetString(0);//Получаем значение из второго столбца! Первый это (0)!
                }
                catch { }

            }

            connectionString.Close();

            connectionString.Open();

            var npgSqlCommand = new NpgsqlCommand("insert into \"Requests\" values(@id_R, @id_T, @id_C, @des, @data, @date, @st)", connectionString);
            npgSqlCommand.Parameters.AddWithValue("@id_R", Convert.ToInt32(result) + 1);
            npgSqlCommand.Parameters.AddWithValue("@id_C", Convert.ToInt32(comboBoxClient.SelectedValue));
            npgSqlCommand.Parameters.AddWithValue("@id_T", Convert.ToInt32(comboBoxType.SelectedValue));
            npgSqlCommand.Parameters.AddWithValue("@des", textBoxDes.Text.ToString());
            npgSqlCommand.Parameters.AddWithValue("@data", textBoxData.Text);
            npgSqlCommand.Parameters.AddWithValue("@date", DateTime.Today);
            npgSqlCommand.Parameters.AddWithValue("@st", Convert.ToInt32(comboBox1.SelectedValue));

            npgSqlCommand.ExecuteNonQuery();


            connectionString.Close();

            AddDataToDataGrid();
        }

        private void отправитToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSend formSend = new FormSend();
            formSend.Show();
        }

        private void выполненныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet dataSetRequest = new DataSet();

            connectionString.Open();

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("select \"Requests\".\"IdRequest\", \"TypeOfRequest\".\"NameType\", \"Clients\".\"FIO\", \"Requests\".\"Descriprion\",  \"Requests\".\"AdditionalInfo\", \"Requests\".\"Date\", \"TypeOfStatus\".\"NameStatus\" from \"Requests\" JOIN \"TypeOfRequest\" ON \"Requests\".\"Type\" = \"TypeOfRequest\".\"IdType\"  JOIN  \"Clients\" ON \"Requests\".\"Client\" = \"Clients\".\"IdClient\" JOIN \"TypeOfStatus\" ON \"Requests\".\"Status\" = \"TypeOfStatus\".\"IdStatus\" where \"TypeOfStatus\".\"IdStatus\" = 2", connectionString);
            dataAdapter.Fill(dataSetRequest);
            dataGridView1.DataSource = dataSetRequest.Tables[0];

            connectionString.Close();
        }

        private void невыполненныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet dataSetRequest = new DataSet();

            connectionString.Open();

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("select \"Requests\".\"IdRequest\", \"TypeOfRequest\".\"NameType\", \"Clients\".\"FIO\", \"Requests\".\"Descriprion\",  \"Requests\".\"AdditionalInfo\", \"Requests\".\"Date\", \"TypeOfStatus\".\"NameStatus\" from \"Requests\" JOIN \"TypeOfRequest\" ON \"Requests\".\"Type\" = \"TypeOfRequest\".\"IdType\"  JOIN  \"Clients\" ON \"Requests\".\"Client\" = \"Clients\".\"IdClient\" JOIN \"TypeOfStatus\" ON \"Requests\".\"Status\" = \"TypeOfStatus\".\"IdStatus\" where \"TypeOfStatus\".\"IdStatus\" = 3", connectionString);
            dataAdapter.Fill(dataSetRequest);
            dataGridView1.DataSource = dataSetRequest.Tables[0];

            connectionString.Close();
        }

        private void вПроцессеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet dataSetRequest = new DataSet();

            connectionString.Open();

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("select \"Requests\".\"IdRequest\", \"TypeOfRequest\".\"NameType\", \"Clients\".\"FIO\", \"Requests\".\"Descriprion\",  \"Requests\".\"AdditionalInfo\", \"Requests\".\"Date\", \"TypeOfStatus\".\"NameStatus\" from \"Requests\" JOIN \"TypeOfRequest\" ON \"Requests\".\"Type\" = \"TypeOfRequest\".\"IdType\"  JOIN  \"Clients\" ON \"Requests\".\"Client\" = \"Clients\".\"IdClient\" JOIN \"TypeOfStatus\" ON \"Requests\".\"Status\" = \"TypeOfStatus\".\"IdStatus\" where \"TypeOfStatus\".\"IdStatus\" = 1", connectionString);
            dataAdapter.Fill(dataSetRequest);
            dataGridView1.DataSource = dataSetRequest.Tables[0];

            connectionString.Close();
        }

        private void всеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDataToDataGrid();
        }

        private void экспортВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelAppli = new Microsoft.Office.Interop.Excel.Application();
            excelAppli.Visible = false;
            excelAppli.Workbooks.Add();

            Microsoft.Office.Interop.Excel.Worksheet xlList = (Microsoft.Office.Interop.Excel.Worksheet)excelAppli.ActiveSheet;

            xlList.Cells[1, 1] = "Номер заявки";
            xlList.Cells[1, 2] = "Тип заявки";
            xlList.Cells[1, 3] = "ФИО клиента";
            xlList.Cells[1, 4] = "Описание";
            xlList.Cells[1, 5] = "Дополнительно";
            xlList.Cells[1, 6] = "Дата обращения";
            xlList.Cells[1, 7] = "Статус";

            int rowExcel = 2;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                xlList.Cells[rowExcel, "A"] = dataGridView1.Rows[i].Cells["Номер заявки"/*"IdRequest"*/].Value;
                xlList.Cells[rowExcel, "B"] = dataGridView1.Rows[i].Cells["Тип заявки"/*"NameType"*/].Value;
                xlList.Cells[rowExcel, "C"] = dataGridView1.Rows[i].Cells["ФИО клиента"/*"FIO"*/].Value;
                xlList.Cells[rowExcel, "D"] = dataGridView1.Rows[i].Cells["Описание"/*"Descriprion"*/].Value;
                xlList.Cells[rowExcel, "E"] = dataGridView1.Rows[i].Cells["Дополнительно"/*"AdditionalInfo"*/].Value;
                xlList.Cells[rowExcel, "F"] = dataGridView1.Rows[i].Cells["Дата обращения"/*"Date"*/].Value;
                xlList.Cells[rowExcel, "G"] = dataGridView1.Rows[i].Cells["Статус"/*"NameStatus"*/].Value;

                ++rowExcel;
            }
            //xlWorkSheet.SaveAs("MyFile.xls");
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Filter = "Excel files(*.xls)|*.xls";
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xlList.SaveAs(SaveFileDialog1.FileName);
                excelAppli.Interactive = true;
                excelAppli.ScreenUpdating = true;
                excelAppli.UserControl = true;
            }
            excelAppli.Quit();
        }
    }
}
