using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace App2.ViewModels
{
    class LoginViewModel:BaseViewModel
    {
        #region variables
        string email;
        string password;
        bool isrunning;
        bool isenabled;
        #endregion

        #region propiedades
        public string Email
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }
        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }
        public bool IsRunning
        {
            get { return this.isrunning; }
            set { SetValue(ref this.isrunning, value); }
        }
        public bool IsEnabled
        {
            get { return this.isenabled; }
            set { SetValue(ref this.isenabled, value); }
        }
        #endregion

        #region comandos
        public ICommand LoginCommand
        {
            get { return new RelayCommand(cmdLogin); }
        }
        private async void cmdLogin()
        {
            if (String.IsNullOrEmpty(Email))
            {
                await App.Current.MainPage.DisplayAlert("Email empty","Please input email","Accept");
                return;
            }
            if (String.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Password empty", "Please entry password", "Accept");
                return;
            }

            IsRunning = true;
        }
        #endregion

    }
}