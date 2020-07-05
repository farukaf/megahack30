using System;
using System.Collections.Generic;
using System.Text;

namespace ButekoGOAPP.ViewModels
{
    public class CupomItemViewModel : ViewModels.BaseViewModel
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string QrCode { get; set; }
        public string CupomNro { get; set; }
        public DateTime Validate { get; set; }
        private bool _IsVisibleQRCode { get; set; }
        public bool IsVisibleQRCode
        {
            get
            {
                return _IsVisibleQRCode;
            }
            set
            {
                _IsVisibleQRCode = value;
                OnPropertyChanged(nameof(IsVisibleQRCode));
            }
        }
    }
}
