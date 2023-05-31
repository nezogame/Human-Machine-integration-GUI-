using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WF_lab1
{
    public partial class REGISTRATION : Form
    {
        private SqlConnection sql_connection = null;
        public bool tf_FIO = true;
        public bool tf_PHONE = true;
        public bool tf_CITY = false;
        private bool check_reg_fields()
        { 
            if (tf_FIO == true) { tbFIO.BackColor = Color.FromArgb(255, 255, 255); }
            if (tf_PHONE == true) { tbPHONE.BackColor = Color.FromArgb(255, 255, 255); }
            if (tf_CITY == true) { cbCITY.BackColor = Color.FromArgb(255, 255, 255); }
            if (tbPASSWORD.Text.Length > 0) { tbPASSWORD.BackColor = Color.FromArgb(255, 255, 255); }

            if (tf_FIO == true && tf_PHONE == true && tf_CITY == true && tbPASSWORD.Text.Length > 0) //временная реализация для password
            {
                return true;
            }
            else
            {
                if (tf_FIO == false){tbFIO.BackColor = Color.FromArgb(255, 0, 25);}
                if (tf_PHONE == false) {tbPHONE.BackColor = Color.FromArgb(255, 0, 25);}
                if (tf_CITY == false) {cbCITY.BackColor = Color.FromArgb(255, 0, 25);}
                if (tbPASSWORD.Text.Length <= 0) {tbPASSWORD.BackColor = Color.FromArgb(255, 0, 25);}
                return false;
            }
        }
        public REGISTRATION()
        {
            InitializeComponent();
        }
        private void buttonREGISTER_Click(object sender, EventArgs e)
        {
            if (check_reg_fields())
            {
                SqlCommand sql_command = new SqlCommand($"INSERT INTO [UserData] (FIO, PhoneNumber, Password, Location, Discount) VALUES (@FIO, @PhoneNumber, @Password, @Location, @Discount)" , sql_connection);
              
                sql_command.Parameters.AddWithValue("FIO" , tbFIO.Text);
                sql_command.Parameters.AddWithValue("PhoneNumber", tbPHONE.Text);
                sql_command.Parameters.AddWithValue("Password", tbPASSWORD.Text);
                sql_command.Parameters.AddWithValue("Location", cbCITY.Text);
                sql_command.Parameters.AddWithValue("Discount", 0);
                sql_command.ExecuteNonQuery();

                MENU_UA_POST f = new MENU_UA_POST(tbFIO.Text);
                f.Show();
                this.Hide();
            }
        }
        private void buttonLOG_IN_Click(object sender, EventArgs e)
        {
            LOG_IN_WINDOW f1 = new LOG_IN_WINDOW();
            f1.Show();
            this.Hide();
        }
        private void tbFIO_Leave(object sender, EventArgs e)
        {
            char[] input = tbFIO.Text.ToCharArray();
            string str = "";

            if (!string.IsNullOrEmpty(tbFIO.Text) )
            {
                for (int i = 0; i < tbFIO.Text.Length; ++i)
                {
                    if (!Char.IsLetter(input[i]) && !str.Contains(input[i]))
                    { 
                        if(string.IsNullOrEmpty(str))
                        {
                            str += input[i];
                        }
                        else str = str + ", " + input[i];
                    }
                }
                if (str.Length > 0)
                {
                    MessageBox.Show("Incorrect values in FIO field: " + str);
                    tf_FIO = false;
                }
                else
                {
                    tf_FIO = true;
                }
            }
        }
        private void tbPHONE_Leave(object sender, EventArgs e)
        {
            char[] input = tbPHONE.Text.ToCharArray();
            string str = "";

            if (!string.IsNullOrEmpty(tbPHONE.Text))
            {
                for (int i = 0; i < tbPHONE.Text.Length; ++i)
                {
                    if (!Char.IsDigit(input[i]) && input[i] != '+' && !str.Contains(input[i]))
                    {
                        if (string.IsNullOrEmpty(str))
                        {
                            str += input[i];
                        }
                        else str = str + ", " + input[i];
                    }
                }
                if (str.Length > 0 || tbPHONE.Text.Length!=13)
                {
                    MessageBox.Show($"Incorrect values in phone field:{str} \nenter 10 digits");
                    tf_PHONE = false;
                }
                else 
                { 
                    tf_PHONE = true;
                }
            }
        }
        private void cbCITY_SelectedIndexChanged(object sender, EventArgs e)
        {
            tf_CITY = true;
        }
        private void REGISTRATION_Load(object sender, EventArgs e)
        {
            sql_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PostDatabase"].ConnectionString);
            sql_connection.Open();
            
            if(sql_connection.State == ConnectionState.Open)
            {
                MessageBox.Show("Connection with database == TRUE");
            }
            else 
            {
                MessageBox.Show("Connection with database == FALSE");
            }
        }
    }
}
