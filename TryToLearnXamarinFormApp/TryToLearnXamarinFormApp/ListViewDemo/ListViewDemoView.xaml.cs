using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ObservableCollection<Contact> _contacts;
        public ListViewDemoView()
        {
            InitializeComponent();

           
            ListView.ItemsSource = GetContacts();
        }

        private IEnumerable GetContacts()
        {
            return _contacts = new ObservableCollection<Contact>
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

        private void Call_OnClicked(object sender, EventArgs e)
        {
          
            Contact contact =(sender as MenuItem).CommandParameter as Contact;
            DisplayAlert("Call Click", contact.Name, "OK");

        }

        private void Delete_OnClicked(object sender, EventArgs e)
        {
            Contact contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }

        private void ListView_OnRefreshing(object sender, EventArgs e)
        {
            ListView.ItemsSource = GetContacts();
            ListView.EndRefresh();
        }
    }
}