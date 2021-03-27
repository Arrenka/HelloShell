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
    public partial class Reg : ContentPage
    {
        public Reg()
        {
            InitializeComponent();
        }
        private async void GoToForward(object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("//reg1");
        }
        private async void GoToBack(object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("//login");
        }

    }
}