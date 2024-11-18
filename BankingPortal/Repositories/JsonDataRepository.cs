using BankingPortal.Services;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace BankingPortal.Repositories
{
    public class JsonDataRepository<T> : IDataRepository<T>
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
                items = JsonSerializer.Deserialize<List<T>>(stream);
            }
            stream.Close();


            return items;
        }
    }
}