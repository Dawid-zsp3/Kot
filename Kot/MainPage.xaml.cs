using Windows.Web.Http.Headers;
using System;
using System.Net.Http;

namespace Kot
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();

        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            imgCat.Source = new UriImageSource
            {
               Uri = new Uri("https://cataas.com/cat?unique=")
            };

        }
        private void OnButtonClicked1(object sender, EventArgs e)
        {
            imgCat1.Source = new UriImageSource
            {
                Uri = new Uri("https://cataas.com/cat?unique=")
            };

        }
        private void OnButtonClicked2(object sender, EventArgs e)
        {
            string kot = koty.Text;
            imgCat2.Source = new UriImageSource
            {
                Uri = new Uri("https://cataas.com/cat/says" + kot)
            };

        }


    }

}