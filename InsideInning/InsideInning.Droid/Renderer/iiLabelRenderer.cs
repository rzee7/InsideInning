using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using InsideInning;
using InsideInning.Droid.Renderer;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(iiLabel), typeof(iiLabelRenderer))]
namespace InsideInning.Droid.Renderer
{
   public class iiLabelRenderer : LabelRenderer
    {
       protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
       {
           base.OnElementChanged(e);
           if (Control != null)
           {
               switch (e.NewElement.ClassId)
               {
                   case "1":

                       Control.SetCompoundDrawablesRelativeWithIntrinsicBounds(Resource.Drawable.Gender, 0, 0, 0);
                       break;
                   case "2":
                       Control.SetCompoundDrawablesRelativeWithIntrinsicBounds(Resource.Drawable.MaritalStatus, 0, 0, 0);
                       break;
                   default:
                       break;
               }
           }
       }   
    }
}