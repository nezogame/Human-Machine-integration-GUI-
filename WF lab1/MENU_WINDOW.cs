using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WF_lab1
{
    public partial class MENU_UA_POST : Form
    {
        Parcel[] parcels_receive;
        Parcel[] parcels_send;

        List<Parcel> receive;
        List<Parcel> send;

        private int parcel_count;
        private SqlConnection sql_connection = null;

        public int x = 25;
        public int y = 460;
        public string fio = "YOU ARE WELCOME DEAR, ";
        public string fio_copy = "";

        public MENU_UA_POST(string fio, ref Parcel[] parcels_to_get, ref Parcel[] parcels_to_send ,ref List<Parcel>receive,ref List<Parcel> send)
        {
            this.receive = new List<Parcel>();
            this.send = new List<Parcel>();
            foreach (var el in receive)
            {
                this.receive.Add(el);
            }
            foreach (var el in send)
            {
                this.send.Add(el);
            }

            this.parcels_receive = new Parcel[parcels_to_get.Length];
            for (int i = 0; i < parcels_to_get.Length; i++)
            {
                this.parcels_receive[i] = parcels_to_get[i];
            }

            if (parcels_to_send != null)
            {
                this.parcels_send = new Parcel[parcels_to_send.Length];
                for (int i = 0; i < parcels_to_send.Length; i++)
                {
                    this.parcels_send[i] = parcels_to_send[i];
                }
            }

            this.fio += fio.ToUpper();
            fio_copy = fio;
            InitializeComponent();
        }
        public MENU_UA_POST(string fio , ref Parcel[] parcels_to_get , ref Parcel[] parcels_to_send)
        {
            this.parcels_receive = new Parcel[parcels_to_get.Length];
            for (int i = 0; i < parcels_to_get.Length; i++)
            {
                this.parcels_receive[i] = parcels_to_get[i];
            }

            if (parcels_to_send!=null)
            {
                this.parcels_send = new Parcel[parcels_to_send.Length];
                for (int i = 0; i < parcels_to_send.Length; i++)
                {
                    this.parcels_send[i] = parcels_to_send[i];
                }
            }

            this.fio += fio.ToUpper();
            fio_copy = fio;
            InitializeComponent();
        }
        public MENU_UA_POST(string fio)
        {
            Random random = new Random();
            parcel_count = random.Next(6, 11);
            this.fio += fio.ToUpper();
            fio_copy = fio;
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label4.SetBounds(x , y , 1 , 1);
            ++x;
            if(x>400)
            {
                x = 25;
            }
        }

        private void MENU_UA_POST_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            if (parcels_receive == null)
            {
                parcels_receive = new Parcel[parcel_count];
                sql_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PostDatabase"].ConnectionString);
                sql_connection.Open();
                SqlDataAdapter data_adapter = new SqlDataAdapter($"SELECT * FROM UserData WHERE FIO='{fio_copy}'", sql_connection);
                DataSet dataset = new DataSet();
                data_adapter.Fill(dataset);
                for (int i = 0; i < parcel_count; ++i)
                {
                    parcels_receive[i] = new Parcel();
                    parcels_receive[i].set_to(dataset.Tables[0].Rows[0].ItemArray[4].ToString());
                    parcels_receive[i].set_from(drop_city(parcels_receive[i].get_to()));
                    parcels_receive[i].calculate_price_and_time();
                    parcels_receive[i].set_pay_status(false);

                    DateTime dt = DateTime.Now;
                    dt = dt.AddDays(random.Next(-4, -1));
                    parcels_receive[i].set_time_departure(dt);
                    parcels_receive[i].set_time_arrival(dt.AddDays(parcels_receive[i].get_duration()));
                    if (parcels_receive[i].get_time_arrival() < DateTime.Now)
                    {
                        parcels_receive[i].set_status("ARRIVED AT DESTINATION");
                    }
                    else parcels_receive[i].set_status("ON THE WAY");
                }
            }
            timer.Interval = 1;
            timer1.Interval = 1;
            timer.Start();
            timer1.Start();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_label.Text = "------------------" + DateTime.Now.ToString() + "------------------";
        }

        private void open_URL(string url)
        {
            Process.Start("cmd", $"/c start {url}");
        }

        private void buttonSHOW_MAP_Click(object sender, EventArgs e)
        {
            open_URL("https://earth.google.com/earth/d/1Mzx_qsMorExmIcPvi9mWnFJeaf9dqDC6?usp=sharing");
        }

        private void buttonCREATE_PARCEL_Click(object sender, EventArgs e)
        {
            CREATE_PARCEL_WINDOW f = new CREATE_PARCEL_WINDOW(fio_copy, ref parcels_receive, ref parcels_send);
            f.Show();
            this.Hide();
        }

        private void buttonPARCELS_Click(object sender, EventArgs e)
        {
            //MY_PARCELS_WINDOW f = new MY_PARCELS_WINDOW(fio_copy);
            //f.Show();
            //this.Hide();

            MY_PARCELS_WINDOW f = new MY_PARCELS_WINDOW(fio_copy , ref parcels_receive , ref parcels_send);
            f.Show();
            this.Hide();
        }

        private void buttonPROMO_Click(object sender, EventArgs e)
        {
            PROMOCODE_WINDOW f = new PROMOCODE_WINDOW(fio_copy);
            f.Show();
            this.Hide();
        }

        private void button_PARCEL_HISTORY_Click(object sender, EventArgs e)
        {
            PARCEL_HISTORY f = new PARCEL_HISTORY(fio_copy, ref parcels_receive, ref parcels_send , ref receive , ref send);
            f.Show();
            this.Hide();
        }

        private void button_diagram_Click(object sender, EventArgs e)
        {
            STATS f = new STATS(fio_copy , ref parcels_receive, ref parcels_send);
            f.Show();
            this.Hide();
        }
    }
}
