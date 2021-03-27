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
    public partial class Bid2 : ContentPage
    {
        bool edited = true; // флаг редактирования
        public BidFirst  BidFirst { get; set; }
        public Bid Bid { get; set; }
        public Bid2(BidFirst bidFirst)
        {
            InitializeComponent();

            BidFirst = bidFirst;
            if (bidFirst == null)
            {
                BidFirst = new BidFirst();
                edited = false;
            }
            this.BindingContext = BidFirst;

            

        }
    }
}