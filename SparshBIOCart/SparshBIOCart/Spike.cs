﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SparshBIOCart
{
    class Spike
    {
        private void Foo()
        {

            ImageCell cell = new ImageCell
            {
                ImageSource = null,
                Text = "hello ",

                
            };

            Page p = new Page
            {
                //BackgroundColor = "white",
            };

            var l = new Label
            {
                Font = Font.SystemFontOfSize(NamedSize.Micro),
            };

            var e = new Entry()
            {

                Keyboard = Keyboard.Numeric,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };


            var c = new ContentView()
            {
                Padding = new Thickness(5),
            };

            var sl = new StackLayout
            {
                Padding = new Thickness(5),
            };
        }
    }
}
