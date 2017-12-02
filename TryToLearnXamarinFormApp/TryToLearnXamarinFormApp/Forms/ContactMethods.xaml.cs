using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TryToLearnXamarinFormApp.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactMethods : ContentPage
    {
        public ListView ContactMethodListView
        {
            get { return ListView; }
        }

        public ContactMethods()
        {
            InitializeComponent();
            ListView.ItemsSource=new List<string>()
            {
                "None","SMS","Email"
            };
        }
    }
}