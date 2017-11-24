using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TryToLearnXamarinFormApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Geeting : ContentPage
    {
        public Geeting()
        {
            InitializeComponent();
            Slider.Value = 0.5;
            //if (Device.RuntimePlatform==Device.iOS)
            //{
            //    Padding=new Thickness(0,20,0,0);
            //}
            //else if (Device.RuntimePlatform==Device.Android)
            //{
            //    Padding = new Thickness(10, 20, 0, 0);
            //}
            //else if (Device.RuntimePlatform == Device.WinPhone)
            //{
            //    Padding = new Thickness(30, 20, 0, 0);
            //}

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;
                case Device.Android:
                    Padding = new Thickness(10, 20, 10, 5);
                    break;
                case Device.WinPhone:
                    Padding = new Thickness(30, 20, 0, 0);
                    break;
                case Device.UWP:
                    Padding = new Thickness(10, 20, 10, 5);
                    break;
                default:
                    Padding = new Thickness(30, 20, 0, 0);
                    break;
            }

        }


    
    }
}