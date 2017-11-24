using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TryToLearnXamarinFormApp.Image
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Image : ContentPage
	{
		public Image ()
		{
			InitializeComponent ();

		    var  imageSourceUrl= new UriImageSource {Uri = new Uri("https://static.pexels.com/photos/196970/pexels-photo-196970.jpeg") };
		    image.Source = imageSourceUrl;
		    image.Aspect = Aspect.Fill;
		}
	}
}