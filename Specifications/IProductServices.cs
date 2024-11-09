using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCO;

namespace Specifications
{
    public interface IProductServices
    {
        List<Product> GetAllProducts();

        Product Get(int ProductId);

        bool Insert(Product product);

        bool Update(Product product);

        bool Delete(int product);

    }
}
