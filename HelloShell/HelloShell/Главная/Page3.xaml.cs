using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloShell
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        //protected internal static ObservableCollection<Page1First> Page1Firsts { get; set; }
        //protected internal static ObservableCollection<BidFirst> bidFirsts { get; set; }
        public Page3()
        {
            //bidFirsts = new ObservableCollection<BidFirst>();
            //Page1List.BindingContext = bidFirsts;
            InitializeComponent();
        }
       

        // обработчик выбора элемента в списке
        private async void OnListViewItemSelected3(object sender, SelectedItemChangedEventArgs args)
        {
            // Получаем выбранный элемент 
            Page1First selectedPage1 = args.SelectedItem as Page1First;
            if (selectedPage1 != null)
            {
                // Снимаем выделение
                Page1List.SelectedItem = null;
                // Переходим на страницу редактирования элемента 
                await Navigation.PushAsync(new Page3Second(selectedPage1));
            }
        }
        private async void ToPage2(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//page2");
        }
    }
}