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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connectionString = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=12345;Database=SystemRequests");

            connectionString .Open();

            int result = 0;
            string getString = "";
            string myQuery = "select \"LoginPassword\".\"Department\" from \"LoginPassword\" where \"LoginPassword\".\"Login\"='" + textBoxLogin.Text + "' and \"LoginPassword\".\"Password\" = '" + textBoxPassword.Text + "'";

            NpgsqlCommand com = new NpgsqlCommand(myQuery, connectionString);
            if (com.ExecuteScalar() != null)
            {

                getString = com.ExecuteScalar().ToString();
            }
            if (getString != "")
            {
                result = Convert.ToInt32(getString);
                if (result == 3)
                {
                    FormRequest formRequest = new FormRequest();
                    formRequest.Show();
                }
                else
                {
                    FormSolution formSolution = new FormSolution(result);
                    formSolution.Show();
                }

                textBoxLogin.Text = "";
                textBoxPassword.Text = "";

                this.Hide();
               // this.Close();
            }
            else
                MessageBox.Show("Неверный логин/пароль"); 

            connectionString.Close();

        }
    }
}
