using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP_Test.Models;
using MVP_Test.Views;

namespace MVP_Test.Presenters
{
    internal class ProductPresenter
    {
        IProduct productView;

        public ProductPresenter(IProduct product)
        {
            productView = product;
        }

        public void Coast()
        {
            Product product = new Product();
            product.Price = Convert.ToDouble(productView.PriceText);
            product.Count = productView.Count;
            productView.CoastText = product.Coast().ToString();
        }
    }
}
