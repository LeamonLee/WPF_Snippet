using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Pattern.Command
{
    public class RelayCommand : ICommand
    {

        Action<object> executeAction;
        Func<object, bool> canExecuteFunc;
        bool canExecuteCache;

        public RelayCommand(Action<object> executeAction, Func<object, bool>canExecuteFunc, bool canExecuteCache)
        {
            this.executeAction = executeAction;
            this.canExecuteFunc = canExecuteFunc;
            this.canExecuteCache = canExecuteCache;
        }

        public bool CanExecute(object parameter)
        {
            if (canExecuteFunc == null)
                return true;
            else
                return canExecuteFunc(parameter);
        }

        public void Execute(object parameter)
        {
            executeAction(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }
    }
}
