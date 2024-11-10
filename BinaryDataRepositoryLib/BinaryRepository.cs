using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Specifications;
using POCO;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Web;

namespace BinaryDataRepositoryLib
{
    public class BinaryRepository : IDataRepository
    {

        public bool Serialize(string filename, List<Product> products)
        {
            //string relativePath = "~/Views/Products/products.dat";
            //string fullPath = System.Web.HttpContext.Current.Server.MapPath(relativePath);
            //string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            bool status = false;
            BinaryFormatter formatter = new BinaryFormatter();
            using(FileStream stream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, products);
                status = true;
                stream.Close();
            }
            return status;
        }




        public List<Product> Deserialize(string filename)
        {
            List<Product> products = new List<Product>();
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(filename,FileMode.Open);

            if(stream!=null)
            {
               products =(List<Product>) formatter.Deserialize(stream);
            }
            stream.Close ();

            return products;
        }
    }
}
