using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module04Navigation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void CarouselPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CarouselPage1());
        }

        private async void TabbedPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TabbedPage1());
        }
    }
}
