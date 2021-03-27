﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloShell
{
    public partial class MainPage : ContentPage
    {
   
        public MainPage()
        {
            InitializeComponent();
   
        }
       
        private async void ToExit(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//login");
        }

        public static implicit operator MainPage(AppShell v)
        {
            throw new NotImplementedException();
        }
    }
}
