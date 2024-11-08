using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderProcessing
{
    public interface IOrderServices
    {
        List<Order> GetAllOrders();
        Order Get(int OrderId);

        bool Insert(Order order);
        bool Update(Order order);
        bool Delete(int order);

        string CheckStatus(Order order);// no need
    }
}
