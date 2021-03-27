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
    public partial class Reg2 : ContentPage
    {
        public Reg2()
        {
            InitializeComponent();
        }

        private async void GoToForward(object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("//reg3");
        }
        private async void ToReg1(object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("//reg1");

        }
    }
}