using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Specifications;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Web;

namespace BinaryDataRepositoryLib
{
    public class BinaryRepository<T> : IDataRepository<T>
    {

        public bool Serialize(string filename, List<T> items)
        {
            //string relativePath = "~/Views/Products/products.dat";
            //string fullPath = System.Web.HttpContext.Current.Server.MapPath(relativePath);
            //string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dat_files","");

            bool status = false;
            BinaryFormatter formatter = new BinaryFormatter();
            using(FileStream stream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, items);
                status = true;
                stream.Close();
            }
            return status;
        }


        public List<T> Deserialize(string filename)
        {
            List<T> items = new List<T>();
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(filename,FileMode.Open);

            if(stream!=null)
            {
               items =(List<T>) formatter.Deserialize(stream);
            }
            stream.Close ();

            return items;
        }
    }
}
