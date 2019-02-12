using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS
{
    class TestHeater : Heater
    {
        public void TurnOn()
        {
            System.Console.WriteLine("Test Heater is on");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Test Heater is off");
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
