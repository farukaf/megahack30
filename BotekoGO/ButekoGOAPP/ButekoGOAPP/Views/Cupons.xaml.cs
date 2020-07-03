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
    public partial class Cupons : ContentPage
    {
        public Cupons()
        {
            InitializeComponent();
            this.BindingContext = new CuponsViewModel(this);

            this.listViewCupons.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                if (e.SelectedItem == null) return;

                Task.Delay(500);

                if (sender is ListView lv) lv.SelectedItem = null;
            };
        }        
    }
}