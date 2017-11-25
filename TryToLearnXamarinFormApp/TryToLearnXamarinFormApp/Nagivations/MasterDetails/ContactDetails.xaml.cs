using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryToLearnXamarinFormApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TryToLearnXamarinFormApp.Nagivations.MasterDetails
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactDetails : ContentPage
    {
        public ContactDetails(Contact contact)
        {
            if (contact==null)
            {
                throw new ArgumentNullException();
            }
            BindingContext = contact;
            InitializeComponent();
          
           // 
        }
    }
}