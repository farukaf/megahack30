using ButekoGOAPP.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ButekoGOAPP.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {        
        public LoginViewModel()
        {            
            this.GoogleLoginCommand = new Command(() =>
            {
                MessagingCenter.Send<Models.Login>(new Models.Login(), "LoginSuccess");
            });

            this.FacebookLoginCommad = new Command(() =>
            {
                MessagingCenter.Send<Models.Login>(new Models.Login(), "LoginSuccess");
            });
        }

        public ICommand GoogleLoginCommand { get; set; }
        public ICommand FacebookLoginCommad { get; set; }
    }
}
