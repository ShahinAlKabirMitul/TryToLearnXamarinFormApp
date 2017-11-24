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
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Hi", "Hello World Xamarin", "OK");
        }
    }
}