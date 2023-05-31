using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WF_lab1
{
    public partial class PROMOCODE_WINDOW : Form
    {
        private SqlConnection sql_connection = null;
        Promo[] promocodes = new Promo[8];
        public bool tf = false;
        public string fio;

        public PROMOCODE_WINDOW(string name_FIO)
        {
            fio = name_FIO;
            InitializeComponent();
        }

        private void PROMOCODE_WINDOW_Load(object sender, EventArgs e)
        {
            string path = "C:\\Users\\denyss\\2_Course\\Human-machine interaction\\WF lab1\\promocodes.txt";
            using (StreamWriter stream = new StreamWriter(path))
            {
                for (int i = 0; i < promocodes.Length; ++i)
                {
                    promocodes[i] = new Promo();
                    stream.WriteLine(promocodes[i].get_promocode());
                }
            }
            sql_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PostDatabase"].ConnectionString);
            sql_connection.Open();
        }

        private void tick_button_Click(object sender, EventArgs e)
        {
            if (promocode_textbox.Text.Length>0)
            {
               for (int i = 0; i < promocodes.Length; ++i)
               {
                    if(promocodes[i].get_promocode() == promocode_textbox.Text)
                    {
                        tf = true;
                        promocodes[i] = new Promo();
                        answer_label.Text = "YOU GET PROMOCODE ON "+ promocodes[i].get_discount() + " %";

                        SqlCommand sql_command = new SqlCommand($"UPDATE UserData SET Discount='{promocodes[i].get_discount()}' WHERE FIO='{fio}'", sql_connection);
                        sql_command.ExecuteNonQuery();
                    }
                }
               
                if (tf == false)
                {
                   answer_label.Text = "THERE IS NO SUCH PROMOCODE";
                }
                else
                {
                    string path = "C:\\Users\\denyss\\2_Course\\Human-machine interaction\\WF lab1\\promocodes.txt";
                    using (StreamWriter stream = new StreamWriter(path))
                    {
                        for (int i = 0; i < promocodes.Length; ++i)
                        {
                            stream.WriteLine(promocodes[i].get_promocode());
                        }
                    }
                }
            }
        }

        private void promocode_textbox_TextChanged(object sender, EventArgs e)
        {
            if(promocode_textbox.Text.Length == 0)
            {
                tf = false;
                answer_label.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MENU_UA_POST f = new MENU_UA_POST(fio);
            f.Show();
            this.Hide();
        }
    }
}
