using EMS_Mobile_App.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Services.Maps;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace EMS_Mobile_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            Method obj = new Method();
            this.InitializeComponent();

            string locationName;

            lblDisplayName.Text = "wisani";
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            //DateTime date = new DateTime();
            lblDisplayName.Text = DateTime.Now.ToString();

        }

        private async void btnSendRequest_Click(object sender, RoutedEventArgs e)
        {
            Method obj = new Method();

            Geolocator geolocator = new Geolocator();
            Geoposition currentPosition = await geolocator.GetGeopositionAsync();
            string address = "pretoria";
            MapLocationFinderResult result = await MapLocationFinder.FindLocationsAsync(
            address, currentPosition.Coordinate.Point, 5);
            myMap.Center = currentPosition.Coordinate.Point;
            getLocationAddress();




        }

        private void btnViewStatus_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(viewStatusPage));
        }

        private void tbnUpdateDetails_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UpdateDetailsPage));
        }

        public async void  getLocationAddress()
        {
     


             Geolocator geolocator = new Geolocator();
            Geoposition currentPosition = await geolocator.GetGeopositionAsync();
            string address = "pretoria";
            MapLocationFinderResult result = await MapLocationFinder.FindLocationsAsync(
              address, currentPosition.Coordinate.Point, 5);

            if (result.Status == MapLocationFinderStatus.Success)
            {
                List<string> locations = new List<string>();
                foreach (MapLocation mapLocation in result.Locations)
                {
                    // create a display string of the map location
                    string display = mapLocation.Address.StreetNumber + " " +
                       mapLocation.Address.Street + Environment.NewLine +
                      mapLocation.Address.Town + ", " +
                      mapLocation.Address.RegionCode + "  " +
                      mapLocation.Address.PostCode + Environment.NewLine +
                      mapLocation.Address.CountryCode;
                    // Add the display string to the location list.
                    locations.Add(display);
                   address = display;
                   lstView.Items.Add("location          " + display);
                }
            }

       
        }


    }
}
