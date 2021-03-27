using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HelloShell
{
    public class BidFirst : INotifyPropertyChanged
    {
        private string cod;
        private string name;
        private string vid;
        private string ed;
        private int count;
        private int price;
        private int srok;
        private string uslov;
        private int cenov;
        private string charak;

        public string Cod
        {
            get { return cod; }
            set { if (cod != value) { cod = value; OnPropertyChanged("Cod"); } }
        }
        public string Name
        {
            get { return name; }
            set { if (name != value) { name = value; OnPropertyChanged("Name"); } }
        }
        public string Vid
        {
            get { return vid; }
            set { if (vid != value) { vid = value; OnPropertyChanged("Vid"); } }
        }
        public string Ed
        {
            get { return ed; }
            set { if (ed != value) { ed = value; OnPropertyChanged("Ed"); } }
        }
        public int Count
        {
            get { return count; }
            set { if (count != value) { count = value; OnPropertyChanged("Count"); } }
        }
        public int Price
        {
            get { return price; }
            set { if (price != value) { price = value; OnPropertyChanged("Price"); } }
        }
        public int Srok
        {
            get { return srok; }
            set { if (srok != value) { srok = value; OnPropertyChanged("Srok"); } }
        }
        public string Uslov
        {
            get { return uslov; }
            set { if (uslov != value) { uslov = value; OnPropertyChanged("Uslov"); } }
        }
        public int Cenov
        {
            get { return cenov; }
            set { if (cenov != value) { cenov = value; OnPropertyChanged("Cenov"); } }
        }
        public string Charak
        {
            get { return charak; }
            set { if (charak != value) { charak = value; OnPropertyChanged("Charak"); } }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
