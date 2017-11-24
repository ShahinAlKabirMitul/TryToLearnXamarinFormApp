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
	public partial class ContactGroup : ContentPage
	{
		public ContactGroup ()
		{
			InitializeComponent ();
		    ListView.ItemsSource = new List<Models.ContactGroup>
		    {
                new Models.ContactGroup("A","A")
                {
                    new Contact()
                    {
                        Name = "Asha",
                        ImageUrl = "http://lorempixel.com/100/100/people/1/",


                    }
                },
		        new Models.ContactGroup("M","M")
		        {
		            new Contact()
		            {
		                Name = "Mitul",
		                ImageUrl = "http://lorempixel.com/100/100/people/2/",


		            }
		        },

            };
        }
	}
}