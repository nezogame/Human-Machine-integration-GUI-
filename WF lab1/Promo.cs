using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_lab1
{
    class Promo
    {
        private string promocode;
        private int discount;
        public Promo()
        {
            //generate discount
            Random r = new Random();
            int val = r.Next(0, 50);
            int val_1 = val % 5;
            discount = val - val_1;

            //generate promocode
            for (int i = 0; i < 8; ++i)
            {
                string symbol = r.Next(0, 9).ToString();
                promocode += symbol;
            }

        }
        public int get_discount()
        {
            return discount;
        }

        public string get_promocode()
        {
            return promocode;
        }
    }
}
