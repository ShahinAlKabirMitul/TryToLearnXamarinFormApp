using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TryToLearnXamarinFormApp.Extesnsion
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DateCell : ViewCell
	{
	    private static BindableProperty LabelProperty = BindableProperty.Create("Label", typeof(string), typeof(DateCell));

	    public string Label
	    {
	        get { return (string) GetValue(LabelProperty); }
            set {SetValue(LabelProperty,value); }
            
	    }
		public DateCell ()
		{
		    BindingContext = this;
			InitializeComponent ();
		}
	}
}