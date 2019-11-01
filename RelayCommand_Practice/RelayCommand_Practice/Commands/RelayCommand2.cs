using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RelayCommand_Practice.Commands
{
    public class RelayCommand2<TParam> : ICommand where TParam : class
    {
        private readonly Action<TParam> _execute;
        private readonly Func<TParam, bool> _canExecute;
 
        public RelayCommand2(Action<TParam> execute) : this(execute, null)
        {
          
        }
        public RelayCommand2(Action<TParam> execute, Func<TParam, bool> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");
            
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter) => _canExecute == null || _canExecute(parameter as TParam);

        //public bool CanExecute(Object parameter)
        //{
        //    return _canExecute == null ? true : _canExecute(parameter as TParam);
        //}

        public void Execute(object parameter) => _execute(parameter as TParam);

        //public void Execute(Object parameter)
        //{
        //    _execute(parameter as TParam);
        //}

        public event EventHandler CanExecuteChanged;
    }
}
