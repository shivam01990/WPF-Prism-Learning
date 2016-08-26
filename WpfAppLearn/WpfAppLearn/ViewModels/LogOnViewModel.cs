using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppLearn.ViewModels
{
    public class LogOnViewModel : BindableBase
    {
        private string resultMessage;
        public string InteractionResultMessage
        {
            get
            {
                return this.resultMessage;
            }
            set
            {
                this.resultMessage = value;
                this.OnPropertyChanged("InteractionResultMessage");
            }
        }
        private string _username;
        private string _password;

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

        public LogOnViewModel()
        {
            this.LoginCommand = new DelegateCommand(this.Login);
            this.NotificationRequest = new InteractionRequest<INotification>();
        }

        public ICommand LoginCommand { get; private set; }
        public ICommand CancelCommand { get; private set; }
        public InteractionRequest<INotification> NotificationRequest { get; private set; }

        public void Login()
        {
            //this.NotificationRequest.Raise(
            //   new Notification { Content = "Notification Message", Title = "Notification" },
            //   n => { InteractionResultMessage = "The user was notified."; });


        }

    }
}
