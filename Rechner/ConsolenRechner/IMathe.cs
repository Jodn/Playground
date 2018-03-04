using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolenRechner
{
    public interface IMathe<T>
    {
        T Addition(T a, T b);
        T Subtraktion(T a, T b);
        T Multiplikation(T a, T b);
        T Division(T a, T b);
        T Invertieren(T a);


    }
}
