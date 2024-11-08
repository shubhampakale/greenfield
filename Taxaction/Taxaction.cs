using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxaction
{
    //Only Taxaction Logic
    public static class Taxaction
    {
        public static void PayIncomeTax(float factor)
        {
            Console.WriteLine("Income Tax is deducted from your account" + factor);
        }
        public static void PayServiceTax(float factor)
        {
            Console.WriteLine("Service Tax is deducted from your account" + factor);
        }

        public static void PayProffesionalTax(float factor)
        {
            Console.WriteLine("Professional Tax is deducted from your account");
        }
        public static void PayGSTTax(float factor)
        {
            Console.WriteLine("GST Tax is deducted from your account");
        }
    }
}
