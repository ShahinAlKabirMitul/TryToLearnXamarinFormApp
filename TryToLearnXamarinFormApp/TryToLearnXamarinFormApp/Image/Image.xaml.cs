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

		    var  imageSourceUrl= new UriImageSource {Uri = new Uri("https://static.tayyar.org/Content/ResizedImages/663/423/outside/160811070329204~sports.jpg") };
		    image.Source = imageSourceUrl;
		    image.Aspect = Aspect.Fill;
		}
	}
}