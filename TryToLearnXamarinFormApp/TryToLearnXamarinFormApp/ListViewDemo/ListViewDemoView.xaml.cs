using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TryToLearnXamarinFormApp.ListViewDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewDemoView : ContentPage
    {
        public ListViewDemoView()
        {
            InitializeComponent();
            var name = new List<String>
            {
                "Mitul",
                "Mosh",
                "Asha"
            };
            ListView.ItemsSource = name;
        }
    }
}