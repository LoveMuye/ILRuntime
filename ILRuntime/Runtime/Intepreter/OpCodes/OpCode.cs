﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ILRuntime.CLR.Method;

namespace ILRuntime.Runtime.Intepreter.OpCodes
{
    struct OpCode
    {
        public OpCodeEnum Code;
        public int TokenInteger;
    }
}
