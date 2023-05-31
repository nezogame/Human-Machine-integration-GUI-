using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WF_lab1
{
    public partial class STATS : Form
    {
        string fio;
        private Parcel[] parcels_receive;
        private Parcel[] parcels_send;
       
        private DiagramPart[] pies_stats;
        private SqlConnection sql_connection = null;
        public STATS(string fio ,ref Parcel[] parcels_to_get, ref Parcel[] parcels_to_send)
        {
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
            this.fio = fio;
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void city_stats()
        {
            pies_stats = new DiagramPart[7];
            string[] cities = { "Dnipro", "Kyiv", "Odessa", "Kharkiv", "Lviv", "Poltava", "Uzhgorod" };
            int[] cities_count = new int[cities.Length];

            sql_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PostDatabase"].ConnectionString);
            sql_connection.Open();

            for (int i = 0; i < cities.Length; i++)
            {
                Random rnd = new Random();
                pies_stats[i] = new DiagramPart();

                SqlDataAdapter data_adapter = new SqlDataAdapter($"SELECT * FROM UserData WHERE Location='{cities[i]}'", sql_connection);
                DataSet dataset = new DataSet();
                data_adapter.Fill(dataset);
                cities_count[i] = dataset.Tables[0].Rows.Count;

                pies_stats[i].int_value = cities_count[i];
                pies_stats[i].value = cities[i];
                pies_stats[i].color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            }
        }
        private void date_stats_receive()
        {
            Random rnd = new Random();
            List<string> dates = new List<string>();
            foreach(var el in parcels_receive)
            {
                if(!dates.Contains(el.get_time_arrival().ToString()))
                {
                    dates.Add(el.get_time_arrival().ToString());
                }
            }

            pies_stats = new DiagramPart[dates.Count];
            
            for (int i = 0; i < pies_stats.Length; i++)
            {
                pies_stats[i] = new DiagramPart();
                pies_stats[i].value = dates[i];
                pies_stats[i].color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            }

            for (int i = 0; i < pies_stats.Length; i++)
            {
                for (int j = 0; j < parcels_receive.Length; j++)
                {
                    if (pies_stats[i].value == parcels_receive[j].get_time_arrival().ToString())
                    {
                        pies_stats[i].int_value++;
                    }
                }
            }

        }
        private void receive_stats()
        {
            if (parcels_receive == null)
            {
                MessageBox.Show("There is not available parcels to receive");
                piePanel.Visible = false;
            }
            else
            {
                Random rnd = new Random();
                List<string> receives = new List<string>();
                foreach (var el in parcels_receive)
                {
                    if (!receives.Contains(el.get_from()))
                    {
                        receives.Add(el.get_from());
                    }
                }
                pies_stats = new DiagramPart[receives.Count];
                for (int i = 0; i < pies_stats.Length; i++)
                {
                    pies_stats[i] = new DiagramPart();
                    pies_stats[i].value = receives[i];
                    pies_stats[i].color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }

                for (int i = 0; i < pies_stats.Length; i++)
                {
                    for (int j = 0; j < parcels_receive.Length; j++)
                    {
                        if (pies_stats[i].value == parcels_receive[j].get_from())
                        {
                            pies_stats[i].int_value++;
                        }
                    }
                }


            }
        }
        private void send_stats()
        {
            if(parcels_send == null)
            {
                MessageBox.Show("There is not available parcels to send");
                piePanel.Visible = false;
            }
            else
            {
                Random rnd = new Random();
                List<string> sends = new List<string>();
                foreach (var el in parcels_send)
                {
                    if (!sends.Contains(el.get_from()))
                    {
                        sends.Add(el.get_from());
                    }
                }
                pies_stats = new DiagramPart[sends.Count];
                for (int i = 0; i < pies_stats.Length; i++)
                {
                    pies_stats[i] = new DiagramPart();
                    pies_stats[i].value = sends[i];
                    pies_stats[i].color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }

                for (int i = 0; i < pies_stats.Length; i++)
                {
                    for (int j = 0; j < parcels_send.Length; j++)
                    {
                        if (pies_stats[i].value == parcels_send[j].get_from())
                        {
                            pies_stats[i].int_value++;
                        }
                    }
                }
            }
        }
        private void piePanel_Paint(object sender , PaintEventArgs e)
        {
            if (pies_stats != null)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                var w = Math.Min(piePanel.ClientSize.Width, piePanel.ClientSize.Height) * 0.85f;
                e.Graphics.TranslateTransform(piePanel.ClientSize.Width / 2f, piePanel.ClientSize.Height / 2f);
                var sum = (float)pies_stats.Sum(p => p.int_value);
                var startAngle = 0f;
                for (int i = 0; i < pies_stats.Length; i++)
                {
                    var pie = pies_stats[i];
                    var sweepAngle = 360 * pie.int_value / sum;
                    using (var br = new SolidBrush(pie.color))
                    {
                        e.Graphics.FillPie(br, -w / 2, -w / 2, w, w, startAngle, sweepAngle);
                        e.Graphics.DrawPie(Pens.Black, -w / 2, -w / 2, w, w, startAngle, sweepAngle);
                    }
                    var state = e.Graphics.Save();
                    var textAngle = startAngle + sweepAngle / 2;
                    e.Graphics.RotateTransform(textAngle);
                    e.Graphics.TranslateTransform(w / 1.85f, 0);
                    e.Graphics.RotateTransform(-textAngle);
                    var sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    string text = pie.value + $"({pie.int_value})";
                    e.Graphics.DrawString(text, piePanel.Font, SystemBrushes.ControlText, 0, 0, sf);
                    e.Graphics.Restore(state);
                    startAngle += sweepAngle;
                }
                e.Graphics.DrawEllipse(Pens.Black, -w / 2, -w / 2, w, w);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox4.Checked = checkBox2.Checked = checkBox3.Checked = false;
                city_stats();
                piePanel.Visible = true;
            }
            else piePanel.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = checkBox3.Checked = checkBox4.Checked = false;
                date_stats_receive();
                piePanel.Visible = true;
            }
            else piePanel.Visible = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = checkBox2.Checked = checkBox4.Checked = false;
                send_stats();
                piePanel.Visible = true;
            }
            else piePanel.Visible = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox1.Checked = checkBox2.Checked = checkBox3.Checked = false;
                receive_stats();
                piePanel.Visible = true;
            }
            else piePanel.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MENU_UA_POST f = new MENU_UA_POST(fio , ref parcels_receive, ref parcels_send);
            f.Show();
            this.Hide();
        }

        private void STATS_Load(object sender, EventArgs e)
        {

        }
    }
}