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
    public partial class Page1Second : ContentPage
    {
        bool edited = true; // флаг редактирования
        public Page1First Page1First { get; set; }
        public Page1 Page1 { get; set; }
        public Page1Second(Page1First page1First)  // конструктор Page1Second получает значение Page1First
        {
            InitializeComponent();

            Page1First = page1First;
            if (page1First == null)
            {
                Page1First = new Page1First();
                edited = false;
            }
            this.BindingContext = Page1First;
        }

        public async void SavePage1(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

            //NavigationPage page = Page1;
            //IReadOnlyList<Page> navStack = page.Navigation.NavigationStack;
            //Page1 homepage = navStack[page.Navigation.NavigationStack.Count - 1] as Page1;

            //if (edited == false)
            //{
            //    if (homepage != null) 
            //    { homepage.AddPhone(Page1First);}
            //}

            

            //если добавление
            if (edited == false)
            {
                //находим в стеке предпоследнюю страницу - то есть MainPage



               NavigationPage navPage = (NavigationPage)Application.Current.MainPage; 
                // невыходит потому что main больше не предполследний элемент в стеке


                Page1 homePage1 = navPage.RootPage as Page1;

                if (homePage1 != null)
                {
                    homePage1.AddPhone(Page1First);
                }
            }
        }
        async void AddToPage2(object sender, EventArgs e)
        {
            Page2.AddItem(int.Parse(numEntry.Text), date1Entry.Text, regiEntry.Text, statEntry.Text, DateTime.Parse(date2Entry.Text), DateTime.Parse(date3Entry.Text), DateTime.Parse(nameEntry.Text), companyEntry.Text, int.Parse(priceLbl.Text)); //Вызываем статичный метод класса Page2 для добавления элемента во вкладку 'Оплата'
            await Shell.Current.GoToAsync("//page2"); //Переход на страницу 'Оплата'

        }

    }
}