﻿using Xamarin.Forms;

namespace SparshBIOCart.Views
{
    public class AboutPage : ContentPage
    {
        public AboutPage()
        {
            Title = "About";

            if (Device.OS != TargetPlatform.Android)
            {
                Content = new Label
                {
                    Text = "This page is not available for your platform",
                };
            }
        }
    }
}