using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolenRechner
{
    public class Vektor
    {
        public Vektor(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
    }
}
