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
    public partial class Page3Second : ContentPage
    {
        bool edited = true; // флаг редактирования
        public Page1First Page1First { get; set; }
        public Page3Second(Page1First page1First)
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
    }
}