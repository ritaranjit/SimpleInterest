using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SImpleInterest
{
    public class SimpleInterest
    {
        public int getSI(int p, int t, int r)
        {
            return (p * t * r) / 100;
        }
    }
}