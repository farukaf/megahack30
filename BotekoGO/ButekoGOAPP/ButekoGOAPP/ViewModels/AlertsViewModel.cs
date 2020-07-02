using ButekoGOAPP.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace ButekoGOAPP.ViewModels
{
    public class AlertsViewModel : ViewModels.BaseViewModel
    {
        Alerts View;
        public AlertsViewModel(Alerts view)
        {
            this.View = view;

            Task.Run(async () => await this.GetAlerts());
        }

        public ObservableCollection<Models.Alerts> ListAlerts { get; private set; }        

        public async Task GetAlerts()
        {
            IsBusy = true;

            var lstAlerts = new ObservableCollection<Models.Alerts>();

            for (int i = 0; i < 5; i++)
            {
                lstAlerts.Add(new Models.Alerts()
                {
                    Icon = ((char)0xf02c).ToString(),
                    TitleAlert = "Novo Cupom:",
                    DiscriptionAlert = "Check-in realizado no Buteko GO",
                    PointsAlert = 25,
                    IsVisibleContent = false
                });
            }

            await Task.Delay(500);

            this.ListAlerts = lstAlerts;
            OnPropertyChanged(nameof(this.ListAlerts));

            IsBusy = false;
        }        

        private Models.Alerts selectedAlerts;

        public Models.Alerts SelectedAlerts
        {
            get { return selectedAlerts; }
            set 
            {
                if (value == null)
                    return;

                selectedAlerts = value;                
                OnPropertyChanged();                
                //criar o message.
            }
        }

    }
}
