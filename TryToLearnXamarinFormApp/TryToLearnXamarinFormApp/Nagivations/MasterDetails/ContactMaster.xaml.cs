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

namespace TryToLearnXamarinFormApp.Nagivations.MasterDetails
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactMaster : ContentPage
    {

        public ContactMaster()
        {
            InitializeComponent();
            ListView.ItemsSource = GetContacts();
        }
        private IEnumerable GetContacts(string search = null)
        {
            var _contacts = new ObservableCollection<Contact>
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

            if (search == null)
            {
                return _contacts;
            }
            return _contacts.Where(s => s.Name.ToLower().StartsWith(search.ToLower()));
        }

        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            if (contact==null)
            {
                return;
            }
            await Navigation.PushAsync(new ContactDetails(contact));
            ListView.SelectedItem = null;
        }
    }
}