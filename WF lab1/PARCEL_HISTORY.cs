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
    public partial class PARCEL_HISTORY : Form
    {
        private SqlConnection sql_connection = null;

        private Parcel[] parcels_receive;
        private Parcel[] parcels_send;

        List<Parcel> receive;
        List<Parcel> send;
        string fio = "";
        int index = 0;
        public PARCEL_HISTORY(string fio, ref Parcel[] parcels_to_get, ref Parcel[] parcels_to_send, ref List<Parcel>receive , ref List<Parcel> send)
        {
            this.fio = fio;
            this.receive = new List<Parcel>();
            this.send = new List<Parcel>();

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


            if (receive != null && send != null)
            {
                foreach (var el in receive)
                {
                    this.receive.Add(el);
                }
                foreach (var el in send)
                {
                    this.send.Add(el);
                }
            }
            InitializeComponent();
        }

        private void PARCEL_HISTORY_Load(object sender, EventArgs e)
        {
            if (receive!=null && send!=null)
            {
                for (int i = 0; i < receive.Count; i++)
                {
                    listbox_receive.Items.Add($"Parcel{i + 1}");
                }
            }
        }

        private void listbox_receive_DoubleClick(object sender, EventArgs e)
        {
                string str = listbox_receive.SelectedItem.ToString();
                label_info_text.Text = str;
                index = listbox_receive.SelectedIndex;
                sql_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PostDatabase"].ConnectionString);
                sql_connection.Open();
                SqlDataAdapter data_adapter = new SqlDataAdapter($"SELECT * FROM UserData WHERE FIO='{fio}'", sql_connection);
                DataSet dataset = new DataSet();
                data_adapter.Fill(dataset);

                label_info_text.Text =
                "INFO ABOUT PARCEL:\n " +
                $"From: {receive[index].get_from()} \n " +
                $"To: {receive[index].get_to()} \n " +
                $"Delivery cost: {receive[index].get_price()}uah \n " +
                "----------------------------------- \n" +
                $"Receiver name: {dataset.Tables[0].Rows[0].ItemArray[1].ToString()} \n" +
                $"Receiver phone: {dataset.Tables[0].Rows[0].ItemArray[2].ToString()} \n" +
                "----------------------------------- \n" +
                $"Departure: {receive[index].get_time_departure()} \n" +
                $"Arrive: {receive[index].get_time_arrival()} \n";

                label_status.Text = receive[index].get_status();
                if (receive[index].get_status() == "ON THE WAY")
                {
                    label_status.ForeColor = Color.Red;
                }
                else label_status.ForeColor = Color.Green;
        }

        private void listbox_send_DoubleClick(object sender, EventArgs e)
        {
            string str = listbox_send.SelectedItem.ToString();
            label_info_text.Text = str;
            index = listbox_send.SelectedIndex;

            label_info_text.Text =
            "INFO ABOUT PARCEL:\n" +
            $"From: {send[index].get_from()},  {send[index].get_adress_from()} \n" +
            $"To: {send[index].get_to()}, {send[index].get_adress_to()} \n " +
            $"Delivery cost: {send[index].get_price()}uah \n" +
            "----------------------------------- \n" +
            $"RECEIVER INFO:\n" +
            $"Name: {send[index].get_receiver_name()} \n" +
            $"Phone: {send[index].get_receiver_phone()} \n";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MENU_UA_POST f = new MENU_UA_POST(fio ,ref parcels_receive,ref parcels_send, ref receive ,ref send);
            f.Show();
            this.Hide();
        }
    }
}
