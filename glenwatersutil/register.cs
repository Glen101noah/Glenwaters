using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace glenwatersutil
{
    public partial class register : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;


        public register()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtlname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtplot_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {

            // CREATE BUTTON

            if (string.IsNullOrEmpty(txtusername.Text) || string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }

            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM glenwaters.userinfo WHERE Username = '" + txtusername.Text + "';";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    MessageBox.Show("Username not available!");

                }
                else
                {

                    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=glenwaters;";
                    string iquery = "INSERT INTO userinfo(`ID`,`Username`, `Password`, `DateCreated`,`LastLogin`, `FirstName`, `LastName`, `PlotNumber`, `Location`, `UserType`)" +
                        " VALUES (NULL, '" + txtusername.Text + "', '" + txtpassword.Text + "', '" + dateTimePicker1.Value + "', '" + dateTimePicker1.Value + "', '" + txtfname.Text + "','" + txtlname.Text + "','" + txtplot.Text + "','" + txtloc.Text + "','" + txtusertype.Text + "')";

                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, databaseConnection);
                    commandDatabase.CommandTimeout = 60;

                    try
                    {
                        databaseConnection.Open();
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        databaseConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Account Successfully Created!");
                }

                connection.Close();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Checker = new Form1();
            Checker.Show();
            Hide();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

