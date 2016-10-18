using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Prog5.Routing.ViewModel
{
    class RouteCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        RouteCommand()
        {
            
        }

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
