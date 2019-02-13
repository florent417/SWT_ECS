using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Tests
{
    class TestHeater : IHeater
    {
        //private bool heaterOn = false;
        public void TurnOn()
        {
            System.Console.WriteLine("Test Heater is on");
            //heaterOn = true;
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Test Heater is off");
            //heaterOn = false;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
