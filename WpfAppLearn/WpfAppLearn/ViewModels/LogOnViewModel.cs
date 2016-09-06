using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfAppLearn.ViewModels
{
    public class LogOnViewModel : BindableBase, IDataErrorInfo
    {
        #region IDataErrorInfo Login

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get
            {
                string result = null;
                if (columnName == "UserName")
                {
                    if (string.IsNullOrEmpty(UserName))
                        result = "Please enter a User Name";
                }
                if (columnName == "Password")
                {
                    if (string.IsNullOrEmpty(Password))
                        result = "Please enter a Password.";
                }
                return result;
            }
        }

        #endregion

        private string _username;
        private string _password;
        private bool _close;

        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                SetProperty(ref _username, value);
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                SetProperty(ref _password, value);

            }
        }


        public bool Close
        {
            get
            {
                return _close;
            }
            set
            {
                SetProperty(ref _close, value);
            }
        }

        public LogOnViewModel()
        {
            this.LoginCommand = new DelegateCommand<object>(this.Login, CanExecute).ObservesProperty(() => UserName);

        }

        private bool CanExecute(object arg)
        {
            return !string.IsNullOrWhiteSpace(UserName);
        }

        public ICommand LoginCommand { get; private set; }
        public ICommand CancelCommand { get; private set; }
        public InteractionRequest<INotification> NotificationRequest { get; private set; }

        public void Login(object arg)
        {
            var passwordBox = (PasswordBox)arg;
            Password = passwordBox.Password;
            if (UserName == "shivam" && Password == "123456")
            {

                Close = true;
            }

        }


    }
}
