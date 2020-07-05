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
        private CuponsViewModel ViewModel;

        public Cupons()
        {
            InitializeComponent();
            this.BindingContext = ViewModel = new CuponsViewModel(this);

            this.listViewCupons.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                if (e.SelectedItem == null) return;

                Task.Delay(500);

                if (ViewModel.ListCupons != null && ViewModel.ListCupons.Any())
                {
                    foreach (var cupom in ViewModel.ListCupons)
                    {
                        cupom.IsVisibleQRCode = false;
                    }
                }

                ViewModel.SelectedCupons.IsVisibleQRCode = true;
            };
        }

    }
}