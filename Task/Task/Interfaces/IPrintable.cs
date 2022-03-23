using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Interfaces
{
    interface IPrintable<T>
    {
        public void Print(T type);
    }
}
