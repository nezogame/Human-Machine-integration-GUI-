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
    public partial class CREATE_PARCEL_WINDOW : Form
    {
        private Parcel[] parcels_send;
        private Parcel[] parcels_receive;
        private int parcel_count;
        private SqlConnection sql_connection = null;
        private string fio;
        public CREATE_PARCEL_WINDOW(string fio , ref Parcel[] parcels_to_get, ref Parcel[] parcels_to_send)
        {
            this.parcels_receive = new Parcel[parcels_to_get.Length];
            for (int i = 0; i < parcels_to_get.Length; i++)
            {
                this.parcels_receive[i] = parcels_to_get[i];
            }

            if (parcels_to_send != null)
            {
                this.parcel_count = parcels_to_send.Length;
                this.parcels_send = new Parcel[parcels_to_send.Length];
                for (int i = 0; i < parcels_to_send.Length; i++)
                {
                    this.parcels_send[i] = parcels_to_send[i];
                }
            }
            else parcels_send = new Parcel[10];

            this.fio = fio;
  
            InitializeComponent();
        }

        private void checkedLB_place_sending_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedLB_place_sending.SelectedIndex;
            for (int i = 0; i < checkedLB_place_sending.Items.Count; ++i)
            {
                if (i != index) {checkedLB_place_sending.SetItemChecked(i, false);}
            }
            if (index == 0) { label_adress_send.Text = "Enter adress of sending:"; }
            else if (index == 1) { label_adress_send.Text = "Enter number of postomat for sending:"; }
            else { label_adress_send.Text = "Enter number of post office to send parcel:"; }
        }

        private void CREATE_PARCEL_WINDOW_Load(object sender, EventArgs e)
        {
            checkedLB_place_sending.Items.Add(place_sending.adress);
            checkedLB_place_sending.Items.Add(place_sending.postomat);
            checkedLB_place_sending.Items.Add(place_sending.post_office);
            checkedLB_place_receiving.Items.Add(place_sending.adress);
            checkedLB_place_receiving.Items.Add(place_sending.postomat);
            checkedLB_place_receiving.Items.Add(place_sending.post_office);
          
            sql_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PostDatabase"].ConnectionString);
            sql_connection.Open();
            SqlDataAdapter data_adapter = new SqlDataAdapter($"SELECT * FROM UserData WHERE FIO='{fio}'", sql_connection);
            DataSet dataset = new DataSet();
            data_adapter.Fill(dataset);

            string phone = dataset.Tables[0].Rows[0].ItemArray[2].ToString();

            label_info.Text = $"Name: {fio} \nPhone: {phone}";
        }

        private void checkedLB_place_receiving_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedLB_place_receiving.SelectedIndex;
            for (int i = 0; i < checkedLB_place_receiving.Items.Count; ++i)
            {
                if (i != index) { checkedLB_place_receiving.SetItemChecked(i, false); }
            }
            if(index == 0){ label_adress_receive.Text = "Enter adress of receiving:"; }
            else if(index == 1) { label_adress_receive.Text = "Enter number of postomat for receiving:"; }
            else{ label_adress_receive.Text = "Enter number of post office to receive parcel:"; }
        }
        public string drop_city(string c)
        {
            Random random = new Random();
            string[] cities = { "Dnipro", "Kyiv", "Odessa", "Kharkiv", "Lviv", "Poltava", "Uzhgorod" };
            int i = random.Next(0, cities.Length);
            while (cities[i] == c) { i = random.Next(0, cities.Length); }
            return cities[i];
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            Array.Resize(ref parcels_send , parcel_count+1);
            SqlDataAdapter data_adapter = new SqlDataAdapter($"SELECT * FROM UserData WHERE FIO='{fio}'", sql_connection);
            DataSet dataset = new DataSet();
            data_adapter.Fill(dataset);

            parcels_send[parcel_count] = new Parcel();
            parcels_send[parcel_count].receiving = (place_receiving)checkedLB_place_receiving.SelectedItem;
            parcels_send[parcel_count].sending = (place_sending)checkedLB_place_sending.SelectedItem;

            //FROM
            if ((place_receiving)checkedLB_place_receiving.SelectedItem == place_receiving.adress)
            {
                parcels_send[parcel_count].set_adress_from(parcels_send[parcel_count].get_adress_ADRESS(tb_adress_receive.Text));
            }
            else if ((place_receiving)checkedLB_place_receiving.SelectedItem == place_receiving.postomat)
            {
                parcels_send[parcel_count].set_adress_from(parcels_send[parcel_count].get_adress_POSTOMAT(tb_adress_receive.Text));
            }
            else parcels_send[parcel_count].set_adress_from(parcels_send[parcel_count].get_adress_POST_OFFICE(tb_adress_receive.Text));
            
            //TO
            if ((place_receiving)checkedLB_place_sending.SelectedItem == place_receiving.adress)
            {
                parcels_send[parcel_count].set_adress_to(parcels_send[parcel_count].get_adress_ADRESS(tb_adress_send.Text));
            }
            else if ((place_receiving)checkedLB_place_sending.SelectedItem == place_receiving.postomat)
            {
                parcels_send[parcel_count].set_adress_to(parcels_send[parcel_count].get_adress_POSTOMAT(tb_adress_send.Text));
            }
            else parcels_send[parcel_count].set_adress_to(parcels_send[parcel_count].get_adress_POST_OFFICE(tb_adress_send.Text));

            parcels_send[parcel_count].set_to(dataset.Tables[0].Rows[0].ItemArray[4].ToString());
            parcels_send[parcel_count].set_from(drop_city(parcels_send[parcel_count].get_to()));
            parcels_send[parcel_count].calculate_price_and_time();
            parcels_send[parcel_count].set_receiver_name(tb_name.Text);
            parcels_send[parcel_count].set_receiver_phone(tb_phone.Text);
            
            ++parcel_count;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Array.Resize(ref parcels_send , parcel_count);
            MENU_UA_POST f = new MENU_UA_POST(fio, ref parcels_receive, ref parcels_send);
            f.Show();
            this.Hide();
        }
    }
}
