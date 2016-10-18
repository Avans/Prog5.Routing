/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:Prog5.Routing"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Prog5.Routing;
using Prog5.Routing.Model;

namespace Prog5.Routing.ViewModel
{
    public class ViewModelLocator
    {
        private IRouter _router;

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            //Registreer 1 object
            _router = new Router();


            SimpleIoc.Default.Register<ViewModel.IRouter>(() => _router); 

            SimpleIoc.Default.Register<ViewModel.Products>();
            SimpleIoc.Default.Register<IProductRepository, ProductRepository>();
        }

        public ViewModel.Products Products
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ViewModel.Products>();
            }
        }


        public ViewModel.Product CurrentProduct
        {
            get
            {
                return Products.SelectedProduct;
            }
        }

        public ViewModel.IRouter Router
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ViewModel.IRouter>();
            }
        }
        
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}