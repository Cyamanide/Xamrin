using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Misc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void RatingChanged(object sender, int rating)
        {
            // Do something with the rating
            // DisplayAlert("Rating changed", string.Format("Rating changed to {0} star(s)", rating), "Ok");
        }
    }
}
