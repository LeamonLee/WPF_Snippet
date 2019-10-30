using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Command_Practice
{
    public class ViewModel
    {
        public ICommand command { get; set; }
        public ViewModel()
        {
            this.command = new MyCommand(ExecuteMethod, canExecuteMethod);
        }

        private bool canExecuteMethod(object parameter) {
            return true;
        }

        private void ExecuteMethod(object parameter) {
            MessageBox.Show("Command execueted without code behind"); 
        }
    }
}
