﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Point
{
    struct Point
    {
        public double X;
        public double Y;


        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}
