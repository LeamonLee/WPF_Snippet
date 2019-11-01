using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RelayCommand_Practice.Commands;

namespace RelayCommand_Practice.ViewModels
{
    class ChangeNameViewModel : ViewModelBase
    {
        public ChangeNameViewModel()
        {
            ChangeMessageCommand = new RelayCommand2<string> (param => Message = param);
        }
        public string Name { get; set; } = "c.y.c";
        private string _message { get; set; } = "hello world!";
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                OnPropertyChanged("Message");
            }
        } 
        public ICommand ChangeMessageCommand { set; get; }
    }
}
