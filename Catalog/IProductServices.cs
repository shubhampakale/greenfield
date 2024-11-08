using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    public interface IProductServices
    {
        List<Product> GetAllProducts();

        Product Get(int ProductId);

        void Insert(Product product);
        void Update(Product product);
        void Delete(int product);

    }
}
