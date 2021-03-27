using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace HelloShell
{
    public class Page1First : INotifyPropertyChanged
    {
      
        private int num;
        private string name;
        private string company;
        private DateTime date1;
        private DateTime date2;
        private DateTime date3;
        private string regi;
        private string stat;
        private int price;


    
        public int Num
        {
            get { return num; }
            set { if (num != value) { num = value; OnPropertyChanged("Num"); } }
        }
        public string Name
        {
            get { return name; }
            set { if (name != value) { name = value; OnPropertyChanged("Name"); } }
        }

        public string Company
        {
            get { return company; }
            set { if (company != value) { company = value; OnPropertyChanged("Company"); } }
        }
        public DateTime Date1
        {
            get { return date1; }
            set { if (date1 != value) { date1 = value; OnPropertyChanged("Date1"); } }
        }
        public DateTime Date2
        {
            get { return date2; }
            set { if (date2 != value) { date2 = value; OnPropertyChanged("Date2"); } }
        }
        public DateTime Date3
        {
            get { return date3; }
            set { if (date3 != value) { date3 = value; OnPropertyChanged("Date3"); } }
        }
        public string Regi
        {
            get { return regi; }
            set { if (regi != value) { regi = value; OnPropertyChanged("Date3"); } }
        }
        public string Stat
        {
            get { return stat; }
            set { if (stat != value) { stat = value; OnPropertyChanged("Date3"); } }
        }
        public int Price
        {
            get { return price; }
            set { if (price != value) { price = value; OnPropertyChanged("Price"); } }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
