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
            this.LoginCommand = new Command(() =>
            {
                MessagingCenter.Send<Models.Login>(new Models.Login(), "LoginSuccess");
            });
        }

        ICommand LoginCommand { get; set; }
    }
}
