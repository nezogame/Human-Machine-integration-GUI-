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
    public partial class PAY_WINDOW : Form
    {
        private SqlConnection sql_connection = null;
        private string fio = "";
        private string card_number = "";
        private bool[] tf = new bool[7];
        private int parcel_count;
        private int index;
        Parcel[] parcels_receive;
        Parcel[] parcels_send;
        Random random = new Random();

        public PAY_WINDOW(string fio, ref Parcel[] parcels_to_receive , ref Parcel[] parcels_to_send)
        {
            this.parcels_receive = new Parcel[parcels_to_receive.Length];
            for (int i = 0; i < parcels_to_receive.Length; i++)
            {
                this.parcels_receive[i] = parcels_to_receive[i];
            }

            if (parcels_to_send != null)
            {
                this.parcels_send = new Parcel[parcels_to_send.Length];
                for (int i = 0; i < parcels_to_send.Length; i++)
                {
                    this.parcels_send[i] = parcels_to_send[i];
                }
            }
            this.fio = fio;
            InitializeComponent();
        }
        public bool check_pay_fields()
        {
            if (tf[1] && tf[2] && tf[3] && tf[4] && tf[5] && tf[6])
            {
                return true;
            }
            else return false;
        }
        private void block1_tb_Leave(object sender, EventArgs e)
        {
            bool tf1 = true;
            char[] input1 = block1_tb.Text.ToCharArray();

            for (int i = 0; i < block1_tb.Text.Length; ++i)
            {
                if (!Char.IsDigit(input1[i]) || block1_tb.Text.Length < 4) { tf1 = false; }
            }
            if (tf1 == false) 
            { 
                MessageBox.Show("You must enter 4 digits!");
                block1_tb.BackColor = (Color.FromArgb(255, 0, 25));
            }
            else block1_tb.BackColor = (Color.FromArgb(255, 255, 255));
            tf[1] = tf1;
        }
        private void block2_tb_Leave(object sender, EventArgs e)
        {
            bool tf2 = true;
            char[] input2 = block2_tb.Text.ToCharArray();

            for (int i = 0; i < block2_tb.Text.Length; ++i)
            {
                if (!Char.IsDigit(input2[i]) || block2_tb.Text.Length < 4) { tf2 = false; }
            }
            if (tf2 == false)
            {
                MessageBox.Show("You must enter 4 digits!");
                block2_tb.BackColor = (Color.FromArgb(255, 0, 25));
            }
            else block2_tb.BackColor = (Color.FromArgb(255, 255, 255));
            tf[2] = tf2;
        }
        private void block3_tb_Leave(object sender, EventArgs e)
        {
            bool tf3 = true;
            char[] input3 = block3_tb.Text.ToCharArray();

            for (int i = 0; i < block3_tb.Text.Length; ++i)
            {
                if (!Char.IsDigit(input3[i]) || block3_tb.Text.Length < 4) { tf3 = false; }
            }
            if (tf3 == false)
            {
                MessageBox.Show("You must enter 4 digits!");
                block3_tb.BackColor = (Color.FromArgb(255, 0, 25));
            }
            else block3_tb.BackColor = (Color.FromArgb(255, 255, 255));
            tf[3] = tf3;
        }
        private void block4_tb_Leave(object sender, EventArgs e)
        {
            bool tf4 = true;
            char[] input4 = block4_tb.Text.ToCharArray();

            for (int i = 0; i < block4_tb.Text.Length; ++i)
            {
                if (!Char.IsDigit(input4[i]) || block4_tb.Text.Length < 4) { tf4 = false; }
            }
            if (tf4 == false)
            {
                MessageBox.Show("You must enter 4 digits!");
                block4_tb.BackColor = (Color.FromArgb(255, 0, 25));
            }
            else block4_tb.BackColor = (Color.FromArgb(255, 255, 255));
            tf[4] = tf4;
        }
        private void month_tb_Leave(object sender, EventArgs e)
        {
            bool tf5 = true;
            char[] input_month = month_tb.Text.ToCharArray();
            string s = new string(input_month);
            int k = Int32.Parse(s);

            for (int i = 0; i < month_tb.Text.Length; ++i)
            {
                if (!Char.IsDigit(input_month[i]) || block1_tb.Text.Length < 4 || k>12 || k<0) { tf5 = false; }
            }
            if (tf5 == false)
            {
                MessageBox.Show("You must enter 2 digits!");
                month_tb.BackColor = (Color.FromArgb(255, 0, 25));
            }
            else month_tb.BackColor = (Color.FromArgb(255, 255, 255));
            tf[5] = tf5;
        }
        private void year_tb_Leave(object sender, EventArgs e)
        {
            bool tf6 = true;
            char[] input_year = year_tb.Text.ToCharArray();
            string s = new string(input_year);
            int k = Int32.Parse(s);

            for (int i = 0; i < year_tb.Text.Length; ++i)
            {
                if (!Char.IsDigit(input_year[i]) || block1_tb.Text.Length < 4 || k > 33 || k<23) { tf6 = false; }
            }
            if (tf6 == false)
            {
                MessageBox.Show("You must enter 2 digits!");
                year_tb.BackColor = (Color.FromArgb(255, 0, 25));
            }
            else year_tb.BackColor = (Color.FromArgb(255, 255, 255));
            tf[6] = tf6;
        }
        private void pay_button_Click(object sender, EventArgs e)
        {
            if(check_pay_fields() && index >= 0)
            {
                int ind = index;
                MessageBox.Show($"-{parcels_receive[index].get_price()}uah");
                // roll_listbox.Items.RemoveAt(index);
                parcels_receive[index].set_pay_status(true);
                //if (ind>=0)
                //{
                //    for (int i = ind; i < parcels_receive.Length - 1; i++)
                //    {
                //        parcels_receive[i] = parcels_receive[i + 1];
                //    }
                //    Array.Resize(ref parcels_receive, parcels_receive.Length - 1);
                //}
            }       
        }
        private void PAY_WINDOW_Load(object sender, EventArgs e)
        {
            sql_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PostDatabase"].ConnectionString);
            sql_connection.Open();
            for (int i = 0; i < parcels_receive.Length; ++i)
            {
                if (parcels_receive[i].get_pay_status() == false)
                {
                    roll_listbox.Items.Add($"Parcel №{i + 1}");
                }
            }
        }
        private void roll_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = roll_listbox.SelectedIndex;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MENU_UA_POST f = new MENU_UA_POST(fio , ref parcels_receive , ref parcels_send);
            f.Show();
            this.Hide();
        }
         private void toogle_switcher_CheckedChanged(object sender, EventArgs e)
         {
            if (toogle_switcher.Checked)
            {
                int dsc_int;
                SqlDataAdapter data_adapter = new SqlDataAdapter($"SELECT * FROM UserData WHERE FIO='{fio}'", sql_connection);
                DataSet dataset = new DataSet();
                data_adapter.Fill(dataset);
                var dsc_string = dataset.Tables[0].Rows[0].ItemArray[5].ToString();
                int.TryParse(dsc_string, out dsc_int);
                parcels_receive[index].set_price(parcels_receive[index].get_price() * (1 - (dsc_int / 100.0)));
                SqlCommand sql_command = new SqlCommand($"UPDATE UserData SET Discount='0' WHERE FIO='{fio}'", sql_connection);
                sql_command.ExecuteNonQuery();
            }
        }
    }
}
