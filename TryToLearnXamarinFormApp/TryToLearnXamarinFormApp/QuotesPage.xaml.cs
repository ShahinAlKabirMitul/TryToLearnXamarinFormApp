using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TryToLearnXamarinFormApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotesPage : ContentPage
	{
	    private int _index = 0;
	    private string[] _quotes = new string[]
	    {
	        "Life is like riding a bicycle. To keep your balance, you must keep moving.",
	        "You can't blame gravity for falling in love.",
	        "Look deep into nature, and then you will understand everything better.",
            "Everybody is a genius. But if you judge a fish by its ability to climb a tree, it will live its whole life believing that it is stupid.",
            "Unthinking respect for authority is the greatest enemy of truth.",
            "Try not to become a man of success, but rather try to become a man of value.",
            "Great spirits have always encountered violent opposition from mediocre minds."
        };



        public QuotesPage ()
		{
			InitializeComponent ();
		}

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        _index++;
	        if (_index >= _quotes.Length)
	            _index = 0;

	        currentQuote.Text = _quotes[_index];

        }
    }
}