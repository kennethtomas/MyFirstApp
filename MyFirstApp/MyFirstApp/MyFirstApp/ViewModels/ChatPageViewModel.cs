using MyFirstApp.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;

namespace MyFirstApp.ViewModels
{
    public class ChatPageViewModel : BindableBase
    {
        private ObservableCollection<ChatMessage> _messageThread;
        public ObservableCollection<ChatMessage> MessageThread
        {
            get { return _messageThread; }
            set { SetProperty(ref _messageThread, value); }
        }

        private string _userInput;
        public string UserInput
        {
            get { return _userInput; }
            set { SetProperty(ref _userInput, value); }
        }

        public DelegateCommand SendCommand { get; set; }
        
        public ChatPageViewModel()
        {
            SendCommand = new DelegateCommand(SendMessage);
            _messageThread = new ObservableCollection<ChatMessage>();
        }

        private void SendMessage()
        {
            //Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);

            //var client = new Greeter.GreeterClient(channel);

            // Save user input to message that will be sent.
            string message = UserInput;
            
            // Clear User input.
            UserInput = "";

            // Add sent message to message thread.
            MessageThread.Add(new ChatMessage
            {
                Message = "(you) " + message,
                TimeStamp = DateTime.Now.ToString()
            });

            // Send message to server
            //var reply = client.SayHello(new HelloRequest { Name = message});

            // Receive message and add message to message thread
            //MessageThread.Add(new ChatMessage
            //{
            //    Message = reply.Message,
            //    TimeStamp = DateTime.Now.ToString()
            //});
            
            //channel.ShutdownAsync().Wait();
        }

        private void TransmitMessage(string message)
        {
            
        }

    }
}
