using ButekoGOAPP.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButekoGOAPP.ViewModels
{
    public class CuponsViewModel : ViewModels.BaseViewModel
    {
        Cupons View;
        public CuponsViewModel(Cupons view)
        {
            this.View = view;

            IsBusy = false;

            Task.Run(async () => await this.GetCupons());
        }

        public ObservableCollection<CupomItemViewModel> ListCupons { get; private set; }

        private async Task GetCupons()
        {
            IsBusy = true;

            var lstCupons = new ObservableCollection<CupomItemViewModel>();

            for (int i = 0; i < 5; i++)
            {
                lstCupons.Add(new CupomItemViewModel()
                {
                    Icon = ((char)0xf02c).ToString(),
                    Title = "Cupom de R$10",
                    Message = "Válido em mais de 5 Butekos na sua área",
                    QrCode = "http://butekogo.com.br/cupom/0000001",
                    CupomNro = "0000001",
                    Validate = DateTime.Now.AddDays(7)
                });
            }

            await Task.Delay(500);

            this.ListCupons = lstCupons;
            OnPropertyChanged(nameof(this.ListCupons));

            IsBusy = false;
        }

        private CupomItemViewModel selectedCupom;

        public CupomItemViewModel SelectedCupons
        {
            get { return selectedCupom; }
            set 
            {
                if (value == null)
                    return;

                selectedCupom = value;                
                OnPropertyChanged();                
            }
        }

    }
}
