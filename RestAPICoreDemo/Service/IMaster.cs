using RestAPICoreDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPICoreDemo.Service
{
   public interface IMaster
    {
        CityMaster AddCity(CityMaster info);

        List<CityMaster> GetAllCity();
    }
}
