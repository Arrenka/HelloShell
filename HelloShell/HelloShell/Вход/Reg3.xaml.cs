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
    public partial class Reg3 : ContentPage
    {
        public Reg3()
        {
            InitializeComponent();
        }
        private async void Go3(object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("//reg2");
        }

        private async void GoToPage1(object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("//page1");
        } 
    }
}