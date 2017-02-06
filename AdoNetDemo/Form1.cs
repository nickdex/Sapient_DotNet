using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnConnected_Click(object sender, EventArgs e)
        {
            OleDbConnection connection;
            InitializeDb(out connection);

            OleDbCommand command = new OleDbCommand();
            command.CommandText = "Select * from Employee";
            command.Connection = connection;
            try
            {
                connection.Open();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (await reader.ReadAsync())
                    {
                        Console.WriteLine("{0} - {1}",reader.GetName(0), reader.GetValue(0));
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }

        private static void InitializeDb(out OleDbConnection connection)
        {
            connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\Users\nwarke\Desktop\NickDb.accdb";
                       
        }

        private void btnDisconnected_Click(object sender, EventArgs e)
        {
            ShowTableValues();
            //InitDataSet();
        }

        private void ShowTableValues()
        {
            OleDbConnection connection;
            InitializeDb(out connection);

            OleDbCommand command = new OleDbCommand();
            command.CommandText = "Select * from Employee";
            command.Connection = connection;

            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command;

            DataSet ds = new DataSet();
            int rows = adapter.Fill(ds);
           
            DataTable table = ds.Tables[0];
            dataGridEmployee.DataSource = table;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnInsert_Click(object sender, EventArgs e)
        {
            // Connected Mode
            OleDbConnection connection;
            InitializeDb(out connection);

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "Insert into Employee (id, name, age, salary ,company) values(@id, @name, @age, @salary ,@company)";
            command.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
            command.Parameters.AddWithValue("@name", txtName.Text);
            command.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text));
            command.Parameters.AddWithValue("@salary", Convert.ToDecimal(txtSalary.Text));
            command.Parameters.AddWithValue("@company", txtCompany.Text);


            try
            {
                connection.Open();
                int rowsInserted = await command.ExecuteNonQueryAsync();
                Console.WriteLine("Rows Inserted - {0}", rowsInserted);
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }

            
        }

        /// <summary>
        /// Updates a row in the data source.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            OleDbConnection connection;
            InitializeDb(out connection);

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "Update Employee set Name = @name where [ID] = @id";
            command.Parameters.AddWithValue("@name", txtName.Text);
            command.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));

            try
            {
                connection.Open();
                int rowsUpdated = await command.ExecuteNonQueryAsync();
                Console.WriteLine("Rows Updated - {0}", rowsUpdated);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }

            ShowTableValues();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            OleDbConnection connection;
            InitializeDb(out connection);

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete * from Employee where [ID] = @id";
            command.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
            //command.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text));
            //command.Parameters.AddWithValue("@salary", Convert.ToDecimal(txtSalary.Text));
            //command.Parameters.AddWithValue("@company", txtCompany.Text);

            try
            {
                connection.Open();
                int rowsDeleted = await command.ExecuteNonQueryAsync();
                Console.WriteLine("Rows Updated - {0}", rowsDeleted);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }

            ShowTableValues();
        }
        
        private void InitDataSet()
        {
            DataSet dataSet = new DataSet();

            DataTable table = new DataTable("Employee");
            string id = "ID";
            string name = "Name";
            string age = "Age";
            table.Columns.Add(id, typeof(int));
            table.Columns.Add(name, typeof(string));
            table.Columns.Add(age, typeof(int));

            DataRow row = table.NewRow();
            row[id] = txtId.Text;
            row[name] = txtName.Text;
            row[age] = txtAge.Text;

            // Adding rows to table
            table.Rows.Add(row);
            table.Rows.Add("12", "Neha", "22");
            // Adding table to dataset
            dataSet.Tables.Add(table);

            var rows = table.Select("2 = 2", "Age DeSC");

            var table1  = rows.CopyToDataTable();

            dataGridEmployee.DataSource = table1;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       
        private void btnClickMe_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adapter;
            DataTable dataTable;
            String queryString1 = "SELECT * FROM Employee";
            OleDbConnection connection;
            InitializeDb(out connection);
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = queryString1;
            adapter = new OleDbDataAdapter(command);

            dataTable = dataGridEmployee.DataSource as DataTable;


            OleDbCommandBuilder oleCommandBuilder;
            try
            {
                connection.Open();
                
                oleCommandBuilder = new OleDbCommandBuilder(adapter);
            adapter.Update(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModeOne()
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\Users\nwarke\Desktop\NickDb.accdb";

            String query1 = "Select * from Employee";
            String query2 = "Select * from [Order]";

            OleDbCommand command1 = new OleDbCommand(query1,connection);
            OleDbCommand command2 = new OleDbCommand(query2, connection);

            OleDbDataAdapter adapter1 = new OleDbDataAdapter(command1);
            OleDbDataAdapter adapter2 = new OleDbDataAdapter(command2);

            DataSet dataSet = new DataSet();

            try
            {
                
                adapter1.Fill(dataSet,"Employee");
                adapter2.Fill(dataSet, "Order");
                dataGridEmployee.DataSource = dataSet.Tables[0];
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private void ModeThree()
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\Users\nwarke\Desktop\NickDb.accdb";

            String query1 = "Select * from Employee";
            String query2 = "Select * from [Order]";

            
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "Insert into Employee (id, name, age, salary ,company) values(@id, @name, @age, @salary ,@company)";
            command.Parameters.AddWithValue("@id", 50);
            command.Parameters.AddWithValue("@name", "OKU;");
            command.Parameters.AddWithValue("@age", 30);
            command.Parameters.AddWithValue("@salary", 3046);
            command.Parameters.AddWithValue("@company", "Gopu");


            DataSet dataSet = new DataSet();
                connection.Open();
            OleDbTransaction transaction = connection.BeginTransaction(); ;
            OleDbCommand command2 = new OleDbCommand(query2, connection, transaction);
            try
            {
                transaction.Begin();
                Console.WriteLine("Rows update - {0}",command.ExecuteNonQuery());
                transaction.Commit();
                //dataGridEmployee.DataSource = dataSet.Tables[0];

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                transaction.Rollback();
            }
        }

        private void btnMode1_Click(object sender, EventArgs e)
        {
            ModeThree();
        }
    }
}
