using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace LabTask_UserDeets
{
    public partial class Form1 : Form
    {
        List<Contact> savedContacts;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
        }

        private void PhoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private bool isEmpty()
        {
            if (NameInput.Text.Equals("") || NumberInput.Text.Equals("") || AddressInput.Text.Equals("") || EmailInput.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            showResuts();
            NameInput.Clear();
            NumberInput.Clear();
            EmailInput.Clear();
            AddressInput.Clear();

            NumberInput.Enabled = true;
        }


        
        
        
        private void showResuts()
        {
            
            string query = "SELECT phone, email,fullname,address FROM phonebook";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            //populate dataGrid
            DataTable dt = new DataTable();

           for(int i =0; i< reader.FieldCount; i++)
            {
                dt.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
            }
           

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dt.Rows.Add(reader["phone"], reader["email"], reader["fullname"], reader["address"]);
                }
            }

            dataGrid.DataSource = dt;

            //           dt.Load(reader);
            //         dataGrid.DataSource = dt;
            //       reader.Close();

            /*savedContacts = new List<Contact>();
            while (reader.Read())
            {
                savedContacts.Add(new Contact()
                {
                    PhoneNumber = reader["phone"].ToString(),
                    Email = reader["email"].ToString(),
                    FullName = reader["fullname"].ToString(),
                    Address = reader["address"].ToString(),

                });        
            }*/
            // dataGrid.DataSource = reader;
               reader.Close();
        }



        private void form_load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UserDeets;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connection = new SqlConnection(connectionString);
            connection.Open();

            //dataGrid.Columns.Add("Phone Number", );

            showResuts();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            showResuts();

            if (!isEmpty())
            {
                SqlCommand command = new SqlCommand($"INSERT INTO phonebook VALUES('{NameInput.Text}', '{NumberInput.Text}', '{AddressInput.Text}', '{EmailInput.Text}')", connection);
                command.ExecuteNonQuery();

                MessageBox.Show("Data Saved");
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
            showResuts();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

            showResuts();
            if (!isEmpty())
            {
                SqlCommand command = new SqlCommand($"UPDATE phonebook SET fullname = '{NameInput.Text}', address = '{AddressInput.Text}', email = '{EmailInput.Text}' WHERE phone = '{NumberInput.Text}'", connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Updated");
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
            showResuts();

            NameInput.Clear();
            NumberInput.Clear();
            EmailInput.Clear();
            AddressInput.Clear();

            
            NumberInput.Enabled = true;

        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            NumberInput.Enabled = false;
            if (dataGrid.SelectedRows.Count > 0)
            {
                NameInput.Text = dataGrid.SelectedRows[0].Cells[2].Value.ToString();
                NumberInput.Text = dataGrid.SelectedRows[0].Cells[0].Value.ToString();
                AddressInput.Text = dataGrid.SelectedRows[0].Cells[3].Value.ToString();
                EmailInput.Text = dataGrid.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string query = $"SELECT phone, email,fullname,address FROM phonebook WHERE fullname LIKE '%{ToBeSearched.Text}%'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            //populate dataGrid
            DataTable dt = new DataTable();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                dt.Columns.Add(reader.GetName(i), reader.GetFieldType(i));

            }

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dt.Rows.Add(reader["phone"], reader["email"], reader["fullname"], reader["address"]);
                }
            }


            dataGrid.DataSource = dt;
            reader.Close();
        }
    }
}