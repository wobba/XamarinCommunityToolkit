﻿using System;
using Xamarin.Forms;

namespace Xamarin.Samples.Views
{
    public partial class EffectsSwitchPage : ContentPage
    {
        public EffectsSwitchPage()
        {
            InitializeComponent();
        }

        async void OnChangeColorButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EffectsSwitchChangeColorPage());
        }
    }
}
