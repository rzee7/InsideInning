﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace InsideInning.Pages
{
    class LeaveDetails: BaseView
    {
        public LeaveDetails()
        {
            var stack = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Spacing = 10
            };

            var stack2 = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Spacing = 10,
                Padding = 10
            };

            var about = new Label
            {
                Font = Font.SystemFontOfSize(NamedSize.Medium),
                Text = "LeaveDetails",
                LineBreakMode = LineBreakMode.WordWrap
            };

            stack2.Children.Add(about);
            stack.Children.Add(new ScrollView { VerticalOptions = LayoutOptions.FillAndExpand, Content = stack2 });
            Content = stack;

        }
    }
}

   