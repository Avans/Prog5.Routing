using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Prog5.Routing.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Prog5.Routing.ViewModel
{
    public class Products : ViewModelBase
    {
        public ObservableCollection<ViewModel.Product> ProductList { get; set; }

        private IProductRepository _productRepo;

        public ViewModel.Product SelectedProduct { get; set; }

        public ICommand GoToDetailsCommand { get; set; }

        public Products(IRouter router, IProductRepository productRepo)
        {
            _productRepo = productRepo;
            var products = _productRepo.GetProducts().Select(p => new ViewModel.Product(p));
            ProductList = new ObservableCollection<Product>(products);

            GoToDetailsCommand = new RelayCommand<string>(router.SetRoute);
        }

         

    }
}
