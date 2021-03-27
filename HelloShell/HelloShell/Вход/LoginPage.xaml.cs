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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (user.Text == "user" && pass.Text == "123") {
                await Shell.Current.GoToAsync("//main");}

        }
        private async void Button_Clicked1(object sender, EventArgs e)
        {
            
                await Shell.Current.GoToAsync("//reg");


        }
    }
}