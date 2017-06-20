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
    public partial class FormSend : Form
    {
        public FormSend()
        {
            InitializeComponent();
        }


        private void FormSend_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "systemRequestsDataSet.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.systemRequestsDataSet.Departments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "systemRequestsDataSet.Requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Fill(this.systemRequestsDataSet.Requests);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connectionString = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=12345;Database=SystemRequests");

            string result = "";

            NpgsqlCommand com = new NpgsqlCommand("select max(\"IdSolition\") from \"Solution\"", connectionString);
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

            try
            {
                var npgSqlCommand = new NpgsqlCommand("insert into \"Solution\" (\"IdSolition\", \"Request\",  \"Department\",  \"DateCome\") values(@id_S, @id_R, @id_D, @date)", connectionString);
                npgSqlCommand.Parameters.AddWithValue("@id_S", Convert.ToInt32(result) + 1);
                npgSqlCommand.Parameters.AddWithValue("@id_R", Convert.ToInt32(comboBoxRequest.SelectedValue));
                npgSqlCommand.Parameters.AddWithValue("@id_D", Convert.ToInt32(comboBoxDep.SelectedValue));
                npgSqlCommand.Parameters.AddWithValue("@date", DateTime.Today);

                npgSqlCommand.ExecuteNonQuery();

                MessageBox.Show("Сообщение отправлено");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Сообщение не отправлено" + ex.Message);
            }

            connectionString.Close();
        }
    }
}
