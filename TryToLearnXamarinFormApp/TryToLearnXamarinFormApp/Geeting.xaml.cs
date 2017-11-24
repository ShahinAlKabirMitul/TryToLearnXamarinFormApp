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
        }


        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            Label.Text = string.Format("Value is {0:F2}", e.NewValue);
        }
    }
}