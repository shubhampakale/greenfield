using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penalty
{
    public class Penalty
    {
        public static void ServiceDissconnectionPenalty(float amount)
        {
            Console.WriteLine("Service Dissconnection Penalty applied " + amount);
        }
        public static void NoificationPenalty(float amount)
        {
            Console.WriteLine("Notification penalty applied " + amount);
        }
    }
}
