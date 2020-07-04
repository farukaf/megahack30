using ButekoGOAPP.Views;
using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace ButekoGOAPP.ViewModels
{
    public class MapViewModel : ViewModels.BaseViewModel
    {
        Map View;
        public MapViewModel(Map view)
        {
            this.View = view;

            IsBusy = false;

            Task.Run(async () => await this.GetPins());
        }        

        public ObservableCollection<Models.Map> ListPins { get; private set; }

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
            
            var lstPins = new ObservableCollection<Models.Map>();

            for (int i = 0; i < 8; i++)
            {
                lstPins.Add(new Models.Map()
                {
                    Latitude = position.Latitude + (3 * i),
                    Longitude = position.Longitude + (4 * i),
                    Description = $"Buteko {i}"
                });
            }

            await Task.Delay(500);

            this.ListPins = lstPins;
            OnPropertyChanged(nameof(this.ListPins));

            IsBusy = false;
        }
    }
}
