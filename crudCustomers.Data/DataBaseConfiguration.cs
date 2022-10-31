using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudCustomers.Data
{
    public class DataBaseConfiguration
    {

        public DataBaseConfiguration(string connnectionString) => ConnnectionString = connnectionString;

        public string ConnnectionString{get; set;}

    }
}
