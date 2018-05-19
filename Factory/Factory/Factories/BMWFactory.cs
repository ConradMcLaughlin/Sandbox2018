using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Autos;

namespace Factory.Factories
{
    public class BMWFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            var bmw = new BMW();
            bmw.SetName("BMW X5");
            return bmw;
        }
    }
}
