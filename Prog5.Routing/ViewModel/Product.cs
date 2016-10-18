using GalaSoft.MvvmLight;
using Prog5.Routing.Model;

namespace Prog5.Routing.ViewModel
{
    public class Product : ViewModelBase
    {
        private Routing.Model.Product p;

        public Product(Routing.Model.Product p)
        {
            this.p = p;
        }

        

        public string Name
        {
            get { return p.Name; }
            set { p.Name = value; }
        }

        public double Price
        {
            get { return p.Price; }
            set { p.Price = value; }
        }
    }
}