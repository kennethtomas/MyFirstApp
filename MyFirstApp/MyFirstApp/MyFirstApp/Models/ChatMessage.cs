using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstApp.Models
{
    public class ChatMessage : BindableBase
    {
        public ChatMessage()
        {

        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private string _timeStamp;
        public string TimeStamp
        {
            get { return _timeStamp; }
            set { SetProperty(ref _timeStamp, value); }
        }
    }
}
