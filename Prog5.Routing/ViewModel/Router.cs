using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Prog5.Routing.ViewModel
{
    public interface IRouter
    {
        UserControl ActiveRoute { get; }

        void SetRoute(string name);
    }

    public class Router : ViewModelBase, IRouter
    {
        private UserControl _activeRoute;
        public UserControl ActiveRoute { get { return _activeRoute; } }

        public Dictionary<string, UserControl> Routes {get; set; }

        public ICommand RouteCommand { get; set; }

        public Router()
        {
            Routes = new Dictionary<string, UserControl>();
            Routes.Add("products", new View.Products());
            Routes.Add("product", new View.Product());

            SetRoute("products");

            RouteCommand = new RelayCommand<string>(SetRoute);

        }

        public void SetRoute(string name)
        {
            this._activeRoute = Routes[name];
        }
    }
}
