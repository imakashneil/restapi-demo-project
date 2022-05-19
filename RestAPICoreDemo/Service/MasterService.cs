using RestAPICoreDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPICoreDemo.Service
{
    public class MasterService : IMaster
    {
        public EmployeeContext _employeeDbContext;
        public MasterService(EmployeeContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }
        public CityMaster AddCity(CityMaster info)
        {
            _employeeDbContext.CityMasters.Add(info);
            _employeeDbContext.SaveChanges();
            return info;
        }
        public List<CityMaster> GetAllCity()
        {
            return _employeeDbContext.CityMasters.ToList();
        }
    }
}
