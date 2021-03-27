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
    public partial class Bid : ContentPage
    {

        protected internal ObservableCollection<BidFirst> bidFirsts { get; set; }
        public Bid()
        {
            InitializeComponent();
            


            bidFirsts = new ObservableCollection<BidFirst>
            {
                new BidFirst { Vid = "Строительные материалы", Cod = "21-050203-10252", Name = "Балка двутавровая горячекатаная с параллельными гранями полок широкополочная из углеродистой стали обыкновенного качества ГОСТ 535-2005(ГОСТ 26020-83) Ш 30.1 H-8000мм", Ed = "шт", Count = 20, Cenov = 0, Srok = 0, Uslov ="Доставка до обьекта", Price = 1, Charak =""}
                
                
            };
            BidList1.BindingContext = bidFirsts;
            
            
        }


        //async void OnCollectionViewSelectionChanged(object sender, SelectedItemChangedEventArgs args)
        //{
        //    BidFirst selectedPage1 = args.SelectedItem as BidFirst;
        //    if (selectedPage1 != null)
        //    {
        //        //Снимаем выделение
        //        BidList1.SelectedItem = null;
        //        //Переходим на страницу редактирования элемента
        //        //await Navigation.PushAsync(new BidSecond(selectedPage1));

        //    }
        //}
        //async void AddToPage3(object sender, EventArgs e)
        //{
        //    Page3.AddItem(int.Parse(numEntry.Text), companyEntry.Text, int.Parse(priceLbl.Text));//Вызываем статичный метод класса Page3 для добавления элемента во вкладку 'Оплата'
        //    await Shell.Current.GoToAsync("//page3"); //Переход на страницу 'Оплата'
        //}

        public async void EditListButton_Clicked(object sender, EventArgs args)
        {
            ImageButton btn = sender as ImageButton;

            BidFirst selectedPage1 = btn.BindingContext as BidFirst;

            if (selectedPage1 == null) return;

            await Navigation.PushAsync(new Bid2((selectedPage1)));

        }

        async void ToPage1(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//page1");
        }


        async void Button_Clicked(object sender, EventArgs e)
        {

            await Shell.Current.GoToAsync("//page1"); 

        }

        //async void Button_Clicked(object sender, EventArgs e)
        //{

        //    Page3.AddItem(EdEntry.Text);//Вызываем статичный метод класса Page3 для добавления элемента во вкладку 'Оплата'
        //    await Shell.Current.GoToAsync("//page3"); //Переход на страницу 'Оплата'

        //}

        //// обработчик выбора элемента в списке
        //async void OnListViewItemSelected(SelectedItemChangedEventArgs args)
        //{
        //    //Получаем выбранный элемент
        //    BidFirst selectedPage1 = args.SelectedItem as BidFirst;
        //    if (selectedPage1 != null)
        //    {
        //        //Снимаем выделение
        //        //BidList1.SelectedItem = null;
        //        BidList1.BindingContext = null;
        //        //Переходим на страницу редактирования элемента
        //        await Navigation.PushAsync(new Bid2(selectedPage1));

        //    }
        //}



    }
}