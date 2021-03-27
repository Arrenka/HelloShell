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
    public partial class Page2 : ContentPage
    {
        protected internal static ObservableCollection<Page1First> Page1Firsts { get; set; } //Делаем коллекцию статичной, для ее доступности в статичных методах класса
       
        public Page2()
        {
            InitializeComponent();
            Page1Firsts = new ObservableCollection<Page1First>();
            Page1List.BindingContext = Page1Firsts;
        }
       
        public static void AddItem(int num, string name, string regi, string stat, DateTime date1, DateTime date2, DateTime date3, string company, int price) //Статичный метод добавления элемента в коллекцию, для ипользования из другого класса
        {
            Page1Firsts.Add(new Page1First { Num = num, Company = company, Price = price, Date1 = date1, Date2 = date2, Date3 = date3, Regi = regi, Stat = stat, Name = name}); //Добавление элемента     
        }
        
        // обработчик выбора элемента в списке
        private async void OnListViewItemSelected2(object sender, SelectedItemChangedEventArgs args)
        {
            // Получаем выбранный элемент 
            Page1First selectedPage1 = args.SelectedItem as Page1First;
            if (selectedPage1 != null)
            {
                // Снимаем выделение
                Page1List.SelectedItem = null;
                // Переходим на страницу редактирования элемента 
                await Navigation.PushAsync(new Page2Second(selectedPage1));
            }
        }
        private async void ToPage1(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//page1");
        }
    }
}