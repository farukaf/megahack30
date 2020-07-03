using System;
using System.Collections.Generic;
using System.Text;

namespace ButekoGOAPP.Models
{
    public class Cupons
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string QrCode { get; set; }
        public string CupomNro { get; set; }
        public DateTime Validate { get; set; }
        public bool IsVisibleQRCode { get; set; }
    }
}
