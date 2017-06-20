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


namespace WorkWithRequest
{
    public partial class FormSolution : Form
    {
        NpgsqlConnection connectionString = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=12345;Database=SystemRequests");
        public int department;

        public FormSolution(int result)
        {
            InitializeComponent();

            department = result;
        }

        private void FormSolution_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "systemRequestsDataSet.TypeOfStatus". При необходимости она может быть перемещена или удалена.
            this.typeOfStatusTableAdapter.Fill(this.systemRequestsDataSet.TypeOfStatus);

            AddDataToComboBox();

            AddDataToDataGrid();
        }

        public void AddDataToComboBox()
        {
            DataSet dataSetRequest = new DataSet();

            connectionString.Open();

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("select \"Solution\".\"IdSolition\", \"Solution\".\"Request\" from \"Solution\" where  \"Solution\".\"Department\" ='" + department + "'", connectionString);

            dataAdapter.Fill(dataSetRequest);

            comboBoxRequest.DataSource = dataSetRequest.Tables[0];
            comboBoxRequest.DisplayMember = "Request";
            comboBoxRequest.ValueMember = "IdSolition";

            connectionString.Close();
        }


        public void AddDataToDataGrid()
        {
            DataSet dataSetSolution = new DataSet();

            connectionString.Open();

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("select \"Solution\".\"IdSolition\", \"Solution\".\"Request\", \"Departments\".\"NameDepartment\",  \"Solution\".\"DateEnd\", \"Solution\".\"Description\",  \"Solution\".\"DateCome\" from \"Solution\" JOIN \"Departments\" ON \"Solution\".\"Department\" = \"Departments\".\"IdDep\" where \"Departments\".\"IdDep\" ='" + department + "'", connectionString);
            //dataAdapter.Fill(dataSetSolution);
            //dataGridView1.DataSource = dataSetSolution.Tables[0];
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            table.Columns["IdSolition"].ColumnName = "Ид решения";
            table.Columns["Request"].ColumnName = "Заявка";
            table.Columns["NameDepartment"].ColumnName = "Название отдела";
            table.Columns["DateEnd"].ColumnName = "Дата окончания";
            table.Columns["Description"].ColumnName = "Описание";
            table.Columns["DateCome"].ColumnName = "Дата обращения";
            dataGridView1.DataSource = table;
            connectionString.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            connectionString.Open();

            var npgSqlCommand = new NpgsqlCommand("update \"Solution\" set \"DateEnd\" = @date, \"Description\"= @des where \"Request\" = '" + Convert.ToInt32(comboBoxRequest.Text) + "';", connectionString);
            npgSqlCommand.Parameters.AddWithValue("@date", DateTime.Today);
            npgSqlCommand.Parameters.AddWithValue("@des", textBox1.Text.ToString());

            npgSqlCommand.ExecuteNonQuery();


            connectionString.Close();

            connectionString.Open();

            var npgSqlCommand1 = new NpgsqlCommand("update \"Requests\" set \"Status\" = @st where \"IdRequest\" = '" + Convert.ToInt32(comboBoxRequest.SelectedValue) + "';", connectionString);
            npgSqlCommand1.Parameters.AddWithValue("@st", Convert.ToInt32(comboBox1.SelectedValue));

            npgSqlCommand1.ExecuteNonQuery();

            connectionString.Close();

            AddDataToDataGrid();
        }
    }
}
