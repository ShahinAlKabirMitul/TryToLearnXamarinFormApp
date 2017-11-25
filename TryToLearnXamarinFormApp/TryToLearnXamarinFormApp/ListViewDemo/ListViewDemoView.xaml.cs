using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryToLearnXamarinFormApp.Models;
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
           
            ListView.ItemsSource = new List<Contact>
            {
                new Contact()
                {
                    Name = "Asha",
                    ImageUrl = "http://lorempixel.com/100/100/people/1/",
                   
                    
                },
                new Contact()
                {
                    Name = "Mitul",
                    ImageUrl = "http://lorempixel.com/100/100/people/5/",
                    Status = "Hey Lets talk"

                }
            };
        }

       
        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            DisplayAlert("Seleted", contact.Name, "OK");
        }
    }
}