using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_lab1
{
    public enum place_sending
    {
        post_office, adress, postomat
    }
    public enum place_receiving
    {
        post_office, adress, postomat
    }
    public class Parcel
    {
        public place_receiving receiving;
        public place_sending sending;
        private string adress_from = "";
        private string adress_to = "";
        private string from ="";
        private string to = "";
        private double price = 0;
        private string receiver_name = "";
        private string receiver_phone = "";
        private bool pay_status = false;
        private string status = ""; //прибыла или не прибыла
        private DateTime departure_time;
        private DateTime arrival_time;
        private int duration = 0;
        public string get_from()
        {
            return from;
        }
        public void set_from(string from)
        {
            this.from = from;
        }
        public string get_to()
        {
            return to;
        }
        public void set_to(string to)
        {
            this.to = to;
        }
        public double get_price()
        {
            return price;
        }
        public void set_price(double price)
        {
            this.price = price;
        }
        public string get_adress_from()
        {
            return adress_from;
        }
        public void set_adress_from(string adress_from)
        {
            this.adress_from = adress_from;
        }
        public string get_adress_to()
        {
            return adress_to;
        }
        public void set_adress_to(string adress_to)
        {
            this.adress_to = adress_to;
        }
        public string get_adress_POSTOMAT(string arg)
        {
            return $"postomat №{arg}";
        }
        public string get_adress_ADRESS(string arg)
        {
            return $"street {arg}";
        }
        public string get_adress_POST_OFFICE(string arg)
        {
            return $"post office №{arg}";
        }
        public string get_receiver_name()
        {
            return receiver_name;
        }
        public void set_receiver_name(string receiver_name)
        {
            this.receiver_name = receiver_name;
        }
        public string get_receiver_phone()
        {
            return receiver_phone;
        }
        public void set_receiver_phone(string receiver_phone)
        {
            this.receiver_phone = receiver_phone;
        }
        public int get_duration()
        {
            return duration;
        }
        public void set_duration(int duration)
        {
            this.duration = duration;
        }
        public DateTime get_time_departure()
        {
            return departure_time;
        }
        public void set_time_departure(DateTime departure_time)
        {
            this.departure_time = departure_time;
        }
        public DateTime get_time_arrival()
        {
            return arrival_time;
        }
        public void set_time_arrival(DateTime arrival_time)
        {
            this.arrival_time = arrival_time;
        }
        public string get_status()
        {
            return status;
        }
        public void set_status(string status)
        {
            this.status = status;
        }
        public bool get_pay_status()
        {
            return pay_status;
        }
        public void set_pay_status(bool pay_status)
        {
            this.pay_status = pay_status;
        }

        public void calculate_price_and_time()
        {
            if ((from=="Dnipro" && to=="Kyiv") || (from == "Kyiv" && to == "Dnipro")) {price = 494 * 0.22; duration = 1; }
            if ((from == "Dnipro" && to == "Odessa") || (from == "Odessa" && to == "Dnipro")){price = 511 * 0.22; duration = 2; }
            if ((from == "Dnipro" && to == "Kharkiv") || (from == "Kharkiv" && to == "Dnipro")) {price = 220 * 0.22; duration = 1; }
            if ((from == "Dnipro" && to == "Lviv") || (from == "Lviv" && to == "Dnipro")) { price = 940 * 0.22; duration = 3; }
            if ((from == "Dnipro" && to == "Poltava") || (from == "Poltava" && to == "Dnipro")) { price = 190 * 0.22; duration = 1; }
            if ((from == "Dnipro" && to == "Uzhgorod") || (from == "Uzhgorod" && to == "Dnipro")) { price = 1100 * 0.22; duration = 3; }

            if ((from == "Kyiv" && to == "Odessa") || (from == "Odessa" && to == "Kyiv")) { price = 480 * 0.22; duration = 1; }
            if ((from == "Kyiv" && to == "Kharkiv") || (from == "Kharkiv" && to == "Kyiv")) { price = 500 * 0.22; duration = 1; }
            if ((from == "Kyiv" && to == "Lviv") || (from == "Lviv" && to == "Kyiv")) { price = 550 * 0.22; duration = 2; }
            if ((from == "Kyiv" && to == "Poltava") || (from == "Poltava" && to == "Kyiv")) { price = 360 * 0.22; duration = 1; }
            if ((from == "Kyiv" && to == "Uzhgorod") || (from == "Uzhgorod" && to == "Kyiv")) { price = 800 * 0.22; duration = 2; }

            if ((from == "Odessa" && to == "Kharkiv") || (from == "Kharkiv" && to == "Odessa")) { price = 820 * 0.22; duration = 2; }
            if ((from == "Odessa" && to == "Lviv") || (from == "Lviv" && to == "Odessa")) { price = 810 * 0.22; duration = 2; }
            if ((from == "Odessa" && to == "Poltava") || (from == "Poltava" && to == "Odessa")) { price = 680 * 0.22; duration = 2; }
            if ((from == "Odessa" && to == "Uzhgorod") || (from == "Uzhgorod" && to == "Odessa")) { price = 1020 * 0.22; duration = 2; }

            if ((from == "Kharkiv" && to == "Lviv") || (from == "Lviv" && to == "Kharkiv")) { price = 1020 * 0.22; duration = 3; }
            if ((from == "Kharkiv" && to == "Poltava") || (from == "Poltava" && to == "Kharkiv")) { price = 150 * 0.22; duration = 1; }
            if ((from == "Kharkiv" && to == "Uzhgorod") || (from == "Uzhgorod" && to == "Kharkiv")) { price = 1310 * 0.22; duration = 3; }

            if ((from == "Lviv" && to == "Poltava") || (from == "Poltava" && to == "Lviv")) { price = 900 * 0.22; duration = 3; }
            if ((from == "Lviv" && to == "Uzhgorod") || (from == "Uzhgorod" && to == "Lviv")) { price = 250 * 0.22; duration = 1; }

            if ((from == "Poltava" && to == "Uzhgorod") || (from == "Uzhgorod" && to == "Poltava")) { price = 1150 * 0.22; duration = 3; }
        }
    }
}
