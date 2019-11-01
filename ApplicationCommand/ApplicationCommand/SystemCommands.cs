using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyCommands
{
    class SystemCommands
    {
        public static RoutedUICommand Quit = new RoutedUICommand("Quit", "QuitCommand", typeof(ApplicationCommand.MainWindow));
    }
}
