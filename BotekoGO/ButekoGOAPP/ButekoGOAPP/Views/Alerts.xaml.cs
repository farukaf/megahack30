using ButekoGOAPP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ButekoGOAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Alerts : ContentPage
    {
        public Alerts()
        {
            InitializeComponent();
            this.BindingContext = new AlertsViewModel(this);

            this.listViewAlerts.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                if (e.SelectedItem == null) return;

                Task.Delay(500);

                if (sender is ListView lv) lv.SelectedItem = null;
            };
        }        
    }
}