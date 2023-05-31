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
using System.Data.SqlClient;

namespace WF_lab1
{
    public partial class MY_PARCELS_WINDOW : Form
    {
        private Parcel[] parcels_receive;
        private Parcel[] parcels_receive_copy;

        private Parcel[] parcels_send;
        private Parcel[] parcels_send_copy;

        private List<Parcel> receive_history;
        private List<Parcel> send_history;

        private int parcel_count;
        private int index;
        private string fio;
        private SqlConnection sql_connection = null;
        bool tf = false;

        public MY_PARCELS_WINDOW(string fio, ref Parcel[] parcels_to_get, ref Parcel[] parcels_to_send)
        {
            receive_history = new List<Parcel>();
            send_history = new List<Parcel>();
            this.parcels_receive = new Parcel[parcels_to_get.Length];
            parcels_receive_copy = new Parcel[parcels_to_get.Length];
            for (int i = 0; i < parcels_to_get.Length; i++)
            {
                this.parcels_receive[i] = parcels_to_get[i];
                parcels_receive_copy[i] = parcels_to_get[i];
            }

            if (parcels_to_send != null)
            {
                this.parcels_send = new Parcel[parcels_to_send.Length];
                parcels_send_copy = new Parcel[parcels_to_send.Length];
                for (int i = 0; i < parcels_to_send.Length; i++)
                {
                    this.parcels_send[i] = parcels_to_send[i];
                }
            }
            this.fio = fio;
            

            InitializeComponent();
        }
        public MY_PARCELS_WINDOW(string fio)
        {
            Random random = new Random();
            this.fio = fio;
            parcel_count = random.Next(3, 6);
          
            InitializeComponent();
        }
        private void MY_PARCELS_WINDOW_Load(object sender, EventArgs e)
        {


            if (!toogleSwitcher.Checked)
            {
                for (int i = 0; i < parcels_receive.Length; ++i)
                {
                    if (parcels_receive[i].get_pay_status() == false)
                    {
                        parcels_listbox.Items.Add("Parcel №" + (i + 1));
                    }
                    else parcels_listbox.Items.Add("Parcel №" + (i + 1) + "(paid)");
                }
            }
            if (parcels_send != null && toogleSwitcher.Checked)
            {
                for (int i = 0; i < parcels_send.Length; ++i)
                {
                    parcels_listbox.Items.Add("Parcel №" + (i + 1));
                }
            }
        }
        public string drop_city(string c)
        {
            Random random = new Random();
            string[] cities = { "Dnipro", "Kyiv", "Odessa", "Kharkiv", "Lviv", "Poltava", "Uzhgorod" };
            int i = random.Next(0, cities.Length);

            while (cities[i] == c)
            {
                i = random.Next(0, cities.Length);
            }
            return cities[i];
        }
        private void pay_button_Click(object sender, EventArgs e)
        {
            if (parcels_listbox.Items.Count > 0)
            {
                parcels_listbox.Items.RemoveAt(index);
                parcel_info_label.Text = "";
                PAY_WINDOW f = new PAY_WINDOW(fio, ref parcels_receive, ref parcels_send);
                f.Show();
                this.Hide();
            }
        }

        private void parcels_listbox_DoubleClick(object sender, EventArgs e)
        {
            if (!toogleSwitcher.Checked)
            {
                string str = parcels_listbox.SelectedItem.ToString();
                parcel_info_label.Text = str;
                index = parcels_listbox.SelectedIndex;
                sql_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PostDatabase"].ConnectionString);
                sql_connection.Open();
                SqlDataAdapter data_adapter = new SqlDataAdapter($"SELECT * FROM UserData WHERE FIO='{fio}'", sql_connection);
                DataSet dataset = new DataSet();
                data_adapter.Fill(dataset);

                parcel_info_label.Text =
                "INFO ABOUT PARCEL:\n " +
                $"From: {parcels_receive[index].get_from()} \n " +
                $"To: {parcels_receive[index].get_to()} \n " +
                $"Delivery cost: {parcels_receive[index].get_price()}uah \n " +
                "----------------------------------- \n" +
                $"Receiver name: {dataset.Tables[0].Rows[0].ItemArray[1].ToString()} \n" +
                $"Receiver phone: {dataset.Tables[0].Rows[0].ItemArray[2].ToString()} \n" +
                "----------------------------------- \n" +
                $"Departure: {parcels_receive[index].get_time_departure()} \n" +
                $"Arrive: {parcels_receive[index].get_time_arrival()} \n";

                label_status.Text = parcels_receive[index].get_status();
                if (parcels_receive[index].get_status() == "ON THE WAY")
                {
                    label_status.ForeColor = Color.Red;
                }
                else label_status.ForeColor = Color.Green;
            }
            else
            {
                string str = parcels_listbox.SelectedItem.ToString();
                parcel_info_label.Text = str;
                index = parcels_listbox.SelectedIndex;

                parcel_info_label.Text =
                "INFO ABOUT PARCEL:\n" +
                $"From: {parcels_send[index].get_from()},  {parcels_send[index].get_adress_from()} \n" +
                $"To: {parcels_send[index].get_to()}, {parcels_send[index].get_adress_to()} \n " +
                $"Delivery cost: {parcels_send[index].get_price()}uah \n" +
                "----------------------------------- \n" +
                $"RECEIVER INFO:\n" +
                $"Name: {parcels_send[index].get_receiver_name()} \n" +
                $"Phone: {parcels_send[index].get_receiver_phone()} \n";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (tf == false)
            {
                MENU_UA_POST f = new MENU_UA_POST(fio, ref parcels_receive, ref parcels_send);
                f.Show();
                this.Hide();
            }
            else
            {
                MENU_UA_POST f = new MENU_UA_POST(fio, ref parcels_receive, ref parcels_send , ref receive_history , ref send_history);
                f.Show();
                this.Hide();
            }
        }

            private void toogleSwitcher_CheckedChanged(object sender, EventArgs e)
        {
            parcel_info_label.Text = "";
            label_status.Text = "";
            if (toogleSwitcher.Checked)
            {
                parcels_listbox.Items.Clear();
                if (parcels_send != null && toogleSwitcher.Checked)
                {
                    for (int i = 0; i < parcels_send.Length; ++i)
                    {
                        parcels_listbox.Items.Add("Parcel №" + (i + 1));
                    }
                }
                pay_button.Visible = false;
            }
            else
            {
                parcels_listbox.Items.Clear();
                if (!toogleSwitcher.Checked)
                {
                    for (int i = 0; i < parcels_receive.Length; ++i)
                    {
                        if (parcels_receive[i].get_pay_status() == false)
                        {
                            parcels_listbox.Items.Add("Parcel №" + (i + 1));
                        }
                        else parcels_listbox.Items.Add("Parcel №" + (i + 1) + "(paid)");
                    }
                }
                pay_button.Visible = true;
            }
        }

        private void sort_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!toogleSwitcher.Checked)
            {
                if (sort_listbox.SelectedIndex == 0)
                {
                    Array.Resize(ref parcels_receive, parcels_receive_copy.Length);
                    for (int i = 0; i < parcels_receive_copy.Length; i++)
                    {
                        parcels_receive[i] = parcels_receive_copy[i];
                    }
                    parcels_listbox.Items.Clear();
                    for (int i = 0; i < parcels_receive.Length; ++i)
                    {
                        if (parcels_receive[i].get_pay_status() == false) { parcels_listbox.Items.Add("Parcel №" + (i + 1)); }
                        else parcels_listbox.Items.Add("Parcel №" + (i + 1) + "(paid)");
                    }
                }
                if (sort_listbox.SelectedIndex == 1)
                {
                    var array_sort_by_price = parcels_receive.OrderByDescending(parcel => parcel.get_price()).ToArray();
                    for (int i = 0; i < parcels_receive.Length; i++)
                    {
                        parcels_receive[i] = array_sort_by_price[i];
                    }
                }
                if (sort_listbox.SelectedIndex == 2)
                {
                    var array_only_paid = parcels_receive.Where(parcel => parcel.get_pay_status() == true).ToArray();
                    Array.Resize(ref parcels_receive, array_only_paid.Length);
                    for (int i = 0; i < array_only_paid.Length; i++)
                    {
                        parcels_receive[i] = array_only_paid[i];
                    }
                    parcels_listbox.Items.Clear();
                    for (int i = 0; i < parcels_receive.Length; ++i)
                    {
                        if (parcels_receive[i].get_pay_status() == false) { parcels_listbox.Items.Add("Parcel №" + (i + 1)); }
                        else parcels_listbox.Items.Add("Parcel №" + (i + 1) + "(paid)");
                    }
                }
                if (sort_listbox.SelectedIndex == 3)
                {
                    var array_sort_by_time = parcels_receive.OrderByDescending(parcel => parcel.get_time_arrival()).ToArray();
                    for (int i = 0; i < parcels_receive.Length; i++)
                    {
                        parcels_receive[i] = array_sort_by_time[i];
                    }
                }
            }
            else
            {
                if (sort_listbox.SelectedIndex == 0)
                {
                    Array.Resize(ref parcels_send, parcels_send_copy.Length);
                    for (int i = 0; i < parcels_send_copy.Length; i++)
                    {
                        parcels_send[i] = parcels_send_copy[i];
                    }
                    parcels_listbox.Items.Clear();
                    for (int i = 0; i < parcels_send.Length; ++i)
                    {
                        if (parcels_send[i].get_pay_status() == false) { parcels_listbox.Items.Add("Parcel №" + (i + 1)); }
                        else parcels_listbox.Items.Add("Parcel №" + (i + 1) + "(paid)");
                    }
                }
                if (sort_listbox.SelectedIndex == 1)
                {
                    var array_sort_by_price = parcels_send.OrderByDescending(parcel => parcel.get_price()).ToArray();
                    for (int i = 0; i < parcels_send.Length; i++)
                    {
                        parcels_send[i] = array_sort_by_price[i];
                    }
                }
                if (sort_listbox.SelectedIndex == 2)
                {
                    var array_only_paid = parcels_send.Where(parcel => parcel.get_pay_status() == true).ToArray();
                    Array.Resize(ref parcels_send, array_only_paid.Length);
                    for (int i = 0; i < array_only_paid.Length; i++)
                    {
                        parcels_send[i] = array_only_paid[i];
                    }
                    parcels_listbox.Items.Clear();
                    for (int i = 0; i < parcels_send.Length; ++i)
                    {
                        if (parcels_send[i].get_pay_status() == false) { parcels_listbox.Items.Add("Parcel №" + (i + 1)); }
                        else parcels_listbox.Items.Add("Parcel №" + (i + 1) + "(paid)");
                    }
                }
                if (sort_listbox.SelectedIndex == 3)
                {
                    var array_sort_by_time = parcels_send.OrderByDescending(parcel => parcel.get_time_arrival()).ToArray();
                    for (int i = 0; i < parcels_send.Length; i++)
                    {
                        parcels_send[i] = array_sort_by_time[i];
                    }
                }
            }
        }

        private void button_take_out_Click(object sender, EventArgs e)
        {
            tf = true;
            if (!toogleSwitcher.Checked)
            {
                int ind = index;
                if(parcels_receive[index].get_pay_status() == true && parcels_receive[index].get_status() == "ARRIVED AT DESTINATION")
                {
                    parcels_receive[index].set_status("RECEIVED");
                    parcels_listbox.Items.RemoveAt(index);
                    //parcels_receive[index].set_pay_status(true);
                    receive_history.Add(parcels_receive[index]);
                    if (ind >= 0)
                    {
                        for (int i = ind; i < parcels_receive.Length - 1; i++)
                        {
                            parcels_receive[i] = parcels_receive[i + 1];
                        }
                        Array.Resize(ref parcels_receive, parcels_receive.Length - 1);
                    }
                }
                else
                {
                    MessageBox.Show($"You didnt pay for this parcel or it still not at destination!");
                }
            }
            else
            {
                if (parcels_send!=null)
                {
                    int ind = index;
                    parcels_receive[index].set_status("RECEIVED, MONEY ISSUED TO RECIPIENT ");
                    parcels_listbox.Items.RemoveAt(index);
                    // parcels_receive[index].set_pay_status(true);
                    send_history.Add(parcels_send[index]);
                    if (ind >= 0)
                    {
                        for (int i = ind; i < parcels_send.Length - 1; i++)
                        {
                            parcels_send[i] = parcels_send[i + 1];
                        }
                        Array.Resize(ref parcels_send, parcels_send.Length - 1);
                    }
                }
                
            }
        }
    }
}
