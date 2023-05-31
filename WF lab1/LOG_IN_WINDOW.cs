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
    public partial class LOG_IN_WINDOW : Form
    {
        private bool tf = false;
        private bool tf_PHONE = false;
        private SqlConnection sql_connection = null;
        public LOG_IN_WINDOW()
        {
            InitializeComponent();
        }

        private void buttonLOG_IN_Click(object sender, EventArgs e)
        {
            string fio ="";
            SqlDataAdapter data_adapter = new SqlDataAdapter(
               $"SELECT * FROM UserData WHERE PhoneNumber ='{tbPHONE.Text}' AND Password ='{tbPASSWORD.Text}'"
               , sql_connection);
            
            DataSet dataset = new DataSet();
            data_adapter.Fill(dataset);

            if(dataset.Tables[0].Rows.Count >= 1)
            {
                tf = true;
            }
            else attention_label.Text = "There is not such account. Try one more time!";
         
            if (tf == true && tf_PHONE == true)
            {
               foreach(DataRow row in dataset.Tables[0].Rows)
               {
                    var cells = row.ItemArray;
                    if (cells.Contains(tbPHONE.Text))
                    {
                       fio = cells[1].ToString();
                    }
               }
                MENU_UA_POST f = new MENU_UA_POST(fio);
                f.Show();
                this.Hide();
            }
        }

        private void LOG_IN_WINDOW_Load(object sender, EventArgs e)
        {
            sql_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PostDatabase"].ConnectionString);
            sql_connection.Open();

            if (tbPASSWORD.Text.Length == 0 && tbPHONE.Text.Length == 0)
            {
                attention_label.Text = "";
            }
        }

        private void tbPHONE_TextChanged(object sender, EventArgs e)
        {
            if (tbPASSWORD.Text.Length == 0 && tbPHONE.Text.Length == 0)
            {
                attention_label.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            REGISTRATION f = new REGISTRATION();
            f.Show();
            this.Hide();
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
                if (str.Length > 0 || tbPHONE.Text.Length != 13)
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
    }
}
