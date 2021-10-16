using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ControlOfShipment
{
    public partial class ControlOfShipment : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapterGet = null;
        private SqlDataAdapter sqlDataAdapterGive = null;
        private DataTable tableGet = null;
        private DataTable tableGive = null;

        public ControlOfShipment()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            string scriptGive = "DELETE FROM RECEPTION";
            SqlCommand commandGive = new SqlCommand(scriptGive, sqlConnection);

            string scriptGet = "DELETE FROM GIVE";
            SqlCommand commandGet = new SqlCommand(scriptGet, sqlConnection);

            commandGive.ExecuteNonQuery();
            commandGet.ExecuteNonQuery();

            sqlDataAdapterGet = new SqlDataAdapter("SELECT * FROM RECEPTION", sqlConnection);
            sqlDataAdapterGive = new SqlDataAdapter("SELECT * FROM GIVE", sqlConnection);

            tableGet = new DataTable();
            tableGive = new DataTable();

            sqlDataAdapterGet.Fill(tableGet);
            sqlDataAdapterGive.Fill(tableGive);

            GetTable.DataSource = tableGet;
            GiveTable.DataSource = tableGive;
        }

        static bool IsHexLetter(char ch)
        {
            return (ch >= 'A' && ch <= 'F') || (ch >= 'a' && ch <= 'F');
        }


        private void Get_CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bool matched = false;
                var data = new Data(Get.Text);

                for (int i = 0; i < data.Value.Length; i++)
                {
                    if (IsHexLetter(data.Value[i]))
                    {
                        matched = true;
                    }

                    else
                    {
                        matched = false;
                        continue;
                    }
                    
                    if (char.IsDigit(data.Value[i]))
                    {
                        matched = true;
                    }

                    else
                    {
                        matched = false;
                        continue;
                    }
                }

                if(matched && data.Value.Length == 24)
                {
                    string script = $"INSERT INTO RECEPTION (Value, Count) VALUES (N'{data.Value.ToUpper()}', N'{data.Count}')";
                    SqlCommand command = new SqlCommand(script, sqlConnection);
                    command.ExecuteNonQuery();
                    sqlDataAdapterGet = new SqlDataAdapter("SELECT * FROM RECEPTION", sqlConnection);

                    tableGet = new DataTable();

                    sqlDataAdapterGet.Fill(tableGet);

                    GetTable.DataSource = tableGet;
                }

                else
                {
                    MessageBox.Show("Неверный идендификатор");
                }
            }
        }

        private void Give_CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                var data = new Data(Give.Text);
                string script = $"INSERT INTO GIVE (Value, Count) VALUES (N'{data.Value.ToUpper()}', N'{data.Count}')";
                SqlCommand command = new SqlCommand(script, sqlConnection);
                command.ExecuteNonQuery();
                sqlDataAdapterGive = new SqlDataAdapter("SELECT * FROM GIVE", sqlConnection);

                tableGive = new DataTable();

                sqlDataAdapterGive.Fill(tableGive);

                GiveTable.DataSource = tableGive;
            }
        }

        private void ControlOfShipment_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gowor\source\repos\ControlOfShipment\ControlOfShipment\Shipment.mdf;Integrated Security=True");

            sqlConnection.Open();

            sqlDataAdapterGet = new SqlDataAdapter("SELECT * FROM RECEPTION", sqlConnection);
            sqlDataAdapterGive = new SqlDataAdapter("SELECT * FROM GIVE", sqlConnection);

            tableGet = new DataTable();
            tableGive = new DataTable();

            sqlDataAdapterGet.Fill(tableGet);
            sqlDataAdapterGive.Fill(tableGive);

            GetTable.DataSource = tableGet;
            GiveTable.DataSource = tableGive;
        }
    }
}
