﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECS
{
    public interface ITempSensor
    {
        int GetTemp();
        bool RunSelfTest();
    }
}