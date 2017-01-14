using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Devices.Geolocation;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Bing.Maps;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace tryMaps1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            locationPermission();
        }

        private async void locationPermission()
        {
            /*Geolocator geolocator = new Geolocator(); 
            if (geolocator.LocationStatus != PositionStatus.Disabled)  
            {         Geoposition geoposition = await geolocator.GetGeopositionAsync();
            var dialog = new MessageDialog(string.Format("The user's coordinates are {0} - {1}", geoposition.Coordinate.Latitude, geoposition.Coordinate.Latitude));
            await dialog.ShowAsync();}*/

            Geolocator gl = new Geolocator();
            Geoposition gp = await gl.GetGeopositionAsync();
            var dialog = new MessageDialog("Latitute: " + gp.Coordinate.Latitude.ToString() + ", Longitute: " + gp.Coordinate.Longitude.ToString());
            await dialog.ShowAsync();
            MyMap.Center = new Location(gp.Coordinate.Latitude, gp.Coordinate.Longitude);
            ClearMap();
            Pushpin pin = new Pushpin();
            pin.Text = "#1";
            pin.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Red);
            MapLayer.SetPosition(pin, MyMap.Center);
            DataLayer.Children.Add(pin); 
            
        }

        private void ClearMap()
        {
            DataLayer.Children.Clear();
        }
        private void AddPushpin_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void AddPolyline_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void AddTileLayer_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ToggleTraffic_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void AddUserControl_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void AddInfobox_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void GeocodeBtn_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ReverseGeocodeBtn_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void DirectionsBtn_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void LoadVenueMap_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void AddPolygon_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }
    }
}
