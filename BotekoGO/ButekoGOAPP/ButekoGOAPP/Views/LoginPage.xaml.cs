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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.LoginViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();            
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();            
        }
    }
}