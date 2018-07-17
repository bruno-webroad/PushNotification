using PushNotificationApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PushNotificationApp.ViewModel
{
    public class MessageViewModel : BaseViewModel
    {
        public ICommand SendCommand { get; set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                NotifyPropertyChanged("Title");
            }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                NotifyPropertyChanged("Message");
            }
        }

        private string _error;
        public string Error
        {
            get { return _error; }
            set
            {
                _error = value;
                NotifyPropertyChanged("Error");
            }
        }

        public MessageViewModel()
        {
            this.SendCommand = new Command(Send);
        }

        private void Send()
        {
            if(string.IsNullOrEmpty(Title) || string.IsNullOrEmpty(Message))
            {
                Error = "Por favor, verifique todos os campos";
                return;
            }

           PushNotificationService.SendMessage(Title, Message);
            Title = "";
            Message = "";
        }
    }
}
