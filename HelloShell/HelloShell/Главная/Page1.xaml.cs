using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Forms.Internals.Profile;

namespace HelloShell
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
         

        protected internal ObservableCollection<Page1First> Page1Firsts { get; set; }

        protected internal ObservableCollection<Page1First> Page1Firsts2 { get; set; }
        public Page1()
        {
            InitializeComponent();

            Page1Firsts = new ObservableCollection<Page1First>
            {
                new Page1First { Num = 18524, Name="Щебень фракция 20-40 на 80м3 ЗР", Company="ТОО «BASYER Construction»",  Date1 = new DateTime(2021, 1, 24), Date2 = new DateTime(2021, 1, 24), Date3 = new DateTime(2021, 2, 03), Regi="Алматы", Stat="Открытый, заявки принимаются", Price=52300},
                new Page1First { Num = 18523, Name="Заявка № 20 на строительные материалы на обьект ПР", Company="ТОО «BASYER Construction»", Date1 = new DateTime(2021, 1, 22), Date2 = new DateTime(2021, 1, 22), Date3 = new DateTime(2021, 2, 01), Regi="Алматы", Stat="Открытый, заявки принимаются", Price=50000},
                new Page1First { Num = 18521, Name="Заявка № 21 на строительные материалы на обьект ЗД", Company="ТОО «BASYER Construction»", Date1 = new DateTime(2021, 1, 22), Date2 = new DateTime(2021, 1, 22), Date3 = new DateTime(2021, 2, 01), Regi="Алматы", Stat="Открытый, заявки принимаются", Price=45000},
                //new Page1First {Num= 21-050301-100090, Company="АРМАТУРА 34028-2016 18 (A500/35ГС)", Price=35000},
                //new Page1First {Num= 21-050301-100090, Company="АРМАТУРА АIII ГОСТ 5781-82, 34028-2016 10 (A500/35ГС)", Price=45200},
                //new Page1First {Num= 21-050301-100090, Company="АРМАТУРА АIII ГОСТ 5781-82 КАЗАХСТАН 12", Price=35600},
                //new Page1First {Num= 21-050301-100090, Company="АРМАТУРА АIII ГОСТ 5781-82 КАЗАХСТАН 14", Price=65000},
                //new Page1First {Num= 21-050301-100090, Company="АРМАТУРА АIII ГОСТ 5781-82 КАЗАХСТАН 16", Price=15000}
            };
            Page1List.BindingContext = Page1Firsts;



            //Date1 = DateTime.Parse("22.01.2021")
        }

       
      



        // обработчик выбора элемента в списке
        //private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        //{
        //    //Получаем выбранный элемент
        //   Page1First selectedPage1 = args.SelectedItem as Page1First;
        //    if (selectedPage1 != null)
        //    {
        //        //Снимаем выделение
        //        Page1List.SelectedItem = null;
        //        //Переходим на страницу редактирования элемента
        //       await Navigation.PushAsync(new Page1Second(selectedPage1));
        //    }
        //}
        // переходим на страницу PhonePage для добавления нового элемента
        private async void AddButton_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1Second(null));
        }
        // вспомогательный метод для добавления элемента в список
        protected internal void AddPhone(Page1First page1First)
        {
            Page1Firsts.Add(page1First);
        }

     
        private async void ToMain(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//list");
        }
    }
}