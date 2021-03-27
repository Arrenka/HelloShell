using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloShell
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage1 : ContentPage
    {

        bool edited = true; // флаг редактирования
        public Person Phone { get; set; }
        public ListViewPage1(Person phone)
        {
            Phone = phone;
            if (phone == null)
            {
                Phone = new Person();
                edited = false;
            }
            this.BindingContext = Phone;
            InitializeComponent();
        }
        public async void ToPage1(object sender, EventArgs args)
        {
            await Shell.Current.GoToAsync("//page1");
        }

        public async void ToBack(object sender, EventArgs args)
        {
            await Shell.Current.GoToAsync("//list");
        }

        public void datePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            if (label != null)
                label.Text = "Вы выбрали " + e.NewDate.ToString("dd/MM/yyyy");
        }
    }
}