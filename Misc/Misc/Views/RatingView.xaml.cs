using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Misc.Views
{
    public partial class RatingView : ContentView
    {
        public event EventHandler<int> RatingChanged;

        public RatingView()
        {
            InitializeComponent();

            SetStarImage(Star1, false);
            SetStarImage(Star2, false);
            SetStarImage(Star3, false);
            SetStarImage(Star4, false);
            SetStarImage(Star5, false);
        }

        private void StarTapped(object sender, EventArgs e)
        {
            SetStarImage(Star1, true);
            SetStarImage(Star2, false);
            SetStarImage(Star3, false);
            SetStarImage(Star4, false);
            SetStarImage(Star5, false);
            RatingChanged?.Invoke(this, 1);
        }

        private void StarTapped1(object sender, EventArgs e)
        {
            SetStarImage(Star1, true);
            SetStarImage(Star2, true);
            SetStarImage(Star3, false);
            SetStarImage(Star4, false);
            SetStarImage(Star5, false);
            RatingChanged?.Invoke(this, 2);
        }

        private void StarTapped2(object sender, EventArgs e)
        {
            SetStarImage(Star1, true);
            SetStarImage(Star2, true);
            SetStarImage(Star3, true);
            SetStarImage(Star4, false);
            SetStarImage(Star5, false);
            RatingChanged?.Invoke(this, 3);
        }

        private void StarTapped3(object sender, EventArgs e)
        {
            SetStarImage(Star1, true);
            SetStarImage(Star2, true);
            SetStarImage(Star3, true);
            SetStarImage(Star4, true);
            SetStarImage(Star5, false);
            RatingChanged?.Invoke(this, 4);
        }

        private void StarTapped4(object sender, EventArgs e)
        {
            SetStarImage(Star1, true);
            SetStarImage(Star2, true);
            SetStarImage(Star3, true);
            SetStarImage(Star4, true);
            SetStarImage(Star5, true);
            RatingChanged?.Invoke(this, 5);
        }

        private void SetStarImage(Image img, bool selected)
        {
            img.HeightRequest = img.Height;
            img.WidthRequest = img.Width;
            img.Source = selected ? ImageSource.FromResource("Misc.Images.fullStar.png") : ImageSource.FromResource("Misc.Images.emptyStar.png");
        }

        protected virtual void OnRatingChanged(int rating)
        {
            RatingChanged?.Invoke(this, rating);
        }
    }
}