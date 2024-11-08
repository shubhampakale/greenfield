using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderProcessing
{
    public class OrderServices :IOrderServices
    {
        private List<Order> _ordersList;
        public OrderServices() { 
            this._ordersList = new List<Order>();
        }

        public bool Delete(int order_id)
        {
            Order theOrder = this.Get(order_id);
            this._ordersList.Remove(theOrder);
            return true;
        }
        public Order Get(int order_id)
        {
            foreach (Order order in this._ordersList)
            {
                if(order.OrderId == order_id)
                {
                    return order;
                }
            }
            return null;
        }
        public List<Order> GetAllOrders() 
        {
            return _ordersList;
        }

        public bool Insert(Order order) 
        {
            this._ordersList.Add(order);
            return true;
        }

        public bool Update(Order order) 
        {
            Order theOrder = this.Get(order.OrderId);
            this._ordersList.Remove(theOrder);
            this._ordersList.Add(order);
            return true;
        }

        public string CheckStatus(Order order) 
        {
            // to be done later
            return null;
        }

    }
}
