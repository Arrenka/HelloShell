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
    public partial class Page2Second : ContentPage
    {
        bool edited = true; // флаг редактирования
        public Page1First Page1First { get; set; }
        public Page2Second(Page1First page1First)
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

        //async void AddToPage3(object sender, EventArgs e)
        //{
        //    Page3.AddItem(int.Parse(numEntry.Text), companyEntry.Text, int.Parse(priceLbl.Text) );//Вызываем статичный метод класса Page3 для добавления элемента во вкладку 'Оплата'
        //    await Shell.Current.GoToAsync("//page3"); //Переход на страницу 'Оплата'
        //}
    }
}