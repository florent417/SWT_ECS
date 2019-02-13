using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECS
{
    public interface IHeater
    {
        void TurnOff();

        void TurnOn();

        bool RunSelfTest();

    }
}