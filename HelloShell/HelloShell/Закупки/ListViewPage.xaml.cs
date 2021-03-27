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
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            BindingContext = new ListViewPageModel();
        }

        public async void EditListButton_Clicked(object sender, EventArgs args)
        {
            Button btn = sender as Button;

            Person selectedPage1 = btn.BindingContext as Person;

            if (selectedPage1 == null) return;

            await Navigation.PushAsync(new ListViewPage1((selectedPage1)));

        }

        public async void ToPage1(object sender, EventArgs args)
        {
            await Shell.Current.GoToAsync("//page1");
        }
    }
}