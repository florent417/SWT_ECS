using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECS
{
    public interface IHeater
    {
        bool RunSelfTest();

        void TurnOff();

        void TurnOn();
    }
}