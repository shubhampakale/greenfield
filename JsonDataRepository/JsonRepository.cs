using Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Runtime.Serialization;

//

namespace JsonDataRepositoryLib
{
    public class JsonRepository<T> : IDataRepository<T>
    {
        public bool Serialize(string filename, List<T> items)
        {
            bool status = false;
            using (FileStream createStream = File.Create(filename))
            {
                JsonSerializer.Serialize(createStream, items);
                status = true;
            }       
           
            return status;
        }
        public List<T> Deserialize(string filename)
        {
            List<T> items = new List<T>();

            FileStream stream = new FileStream(filename, FileMode.Open);
           
            if (stream != null)
            {
                items = JsonSerializer.Deserialize< List <T> >(stream);
            }
            stream.Close(); 
            

            return items;
        }

    }
}
