﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App1
{
    public class Page2 : ContentPage
    {
        public Page2()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello Page" }
                }
            };
        }
    }
}
