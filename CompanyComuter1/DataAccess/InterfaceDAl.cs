using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyComuter1.Models;

namespace CompanyComuter1.Controllers
{
    interface InterfaceDAl
    {
        //Employee
         void CreateEmployee(string ssn, string firstname, string lastname);
        void UpdateEmployee(string ssn, string firstname, string lastname);
        void DeleteEmployee(string ssn);
        void FindEmployeeBySsn(string ssn); 
        List<Employee> GetAllEmployees();
        List<Employee> Top5Employees();

        //Logs
        void CreateLog(string ssn, string vtype, decimal distance);
        void UpdateLog(int id, string vtype, decimal distance);
        void DeleteLog(int id);
        void FindLogById(int id);

        List<EmissionLog> GetAllLogs();
    }
}
