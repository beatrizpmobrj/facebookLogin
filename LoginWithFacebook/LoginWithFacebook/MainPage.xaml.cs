﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginWithFacebook
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnLogar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }
    }
}