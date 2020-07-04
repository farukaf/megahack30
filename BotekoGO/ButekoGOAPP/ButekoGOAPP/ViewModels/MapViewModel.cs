using ButekoGOAPP.Views;
using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms.Maps;

namespace ButekoGOAPP.ViewModels
{
    public class MapViewModel : ViewModels.BaseViewModel
    {
        Views.Map View;
        public MapViewModel(Views.Map view)
        {
            this.View = view;

            IsBusy = false;

            Task.Run(async () => await this.GetPins());
        }      

        public async Task GetPins()
        {
            IsBusy = true;

            //Setting the current location
            var locator = CrossGeolocator.Current;
            var position = await locator.GetPositionAsync(new TimeSpan(0, 0, 10));
            var map = (Xamarin.Forms.Maps.Map)this.View.FindByName("map");
            map.MoveToRegion(Xamarin.Forms.Maps.MapSpan.FromCenterAndRadius(new Xamarin.Forms.Maps.Position(position.Latitude, position.Longitude), Xamarin.Forms.Maps.Distance.FromKilometers(1)));

            //Setting the zoom on current position
            var zoomLevel = 14; //Level between 1 and 18
            var latlongdegress = 360 / (Math.Pow(2, zoomLevel));
            map.MoveToRegion(new Xamarin.Forms.Maps.MapSpan(map.VisibleRegion.Center, latlongdegress, latlongdegress));            

            for (int i = 0; i < 8; i++)
            {
                map.Pins.Add(new Pin()
                {
                    Address = $"Pin {i}",
                    Label = $"Buteko {i}",
                    Position = RandomPosition.Next(new Position(position.Latitude, position.Longitude), 0.001, 0.001),
                    Type = PinType.Place
                });
            }            

            await Task.Delay(500);           

            IsBusy = false;
        }        
    }
}
