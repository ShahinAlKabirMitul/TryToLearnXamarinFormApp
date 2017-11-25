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

    public class ContactMethod
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
    public partial class PickerForm : ContentPage
    {
        private IList<ContactMethod> _contactMethods;
        public PickerForm()
        {
            InitializeComponent();
            _contactMethods = GetContactMethods();
            foreach (ContactMethod con in _contactMethods)
            {
                contactMethods.Items.Add(con.Name);
            }
        }

        private IList<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod>()
            {
                new ContactMethod(){Id = 1,Name = "SMS"},
                new ContactMethod(){Id = 2,Name = "Email"}
            };
        }


        private void Picker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var item = contactMethods.Items[contactMethods.SelectedIndex];

            var contact = _contactMethods.Single(s => s.Name == item);

            DisplayAlert("Selection","Name="+ contact.Name+"& ID"+contact.Id, "OK");
        }

        
    }
}