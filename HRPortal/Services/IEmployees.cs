using HRPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Services
{
    public interface IEmployees
    {
        List<Employees> GetAllEmployees();

        Employees Get(int Id);

        void Create(Employees employee);

        bool Update(Employees employee);

        bool Delete(int employee);
    }
}
