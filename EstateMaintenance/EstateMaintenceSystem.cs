using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaintenance
{
    public class EstateMaintenceSystem
    {
        public string Name { get; set; }

        public List<IProperty> Properties { get; set; }

        public List<IPerson> Persons { get; set; }

        public EstateMaintenceSystem(string name)
        {
            Name = name;
            Properties = new List<IProperty>();
            Persons = new List<IPerson>();
        }
    }
}
