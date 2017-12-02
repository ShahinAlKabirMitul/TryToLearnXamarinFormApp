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
    public partial class frmTableView : ContentPage
    {
        public frmTableView()
        {
            InitializeComponent();
        }

        private  void Cell_OnTapped(object sender, EventArgs e)
        {
            var page = new ContactMethods();
            page.ContactMethodListView.ItemSelected += (source, args) =>
            {
                contactMethod.Text = args.SelectedItem.ToString();
                Navigation.PopAsync();
            };
             Navigation.PushAsync(page);
        }
    }
}