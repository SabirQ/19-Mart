using System;
using System.Collections.Generic;
using System.Text;
using Task.Interfaces;

namespace Task.Models
{
    class MainPrintFile<T>:IPrintable<T>
    {
        public MainPrintFile(T type)
        {
            Print(type);
        }

        public void Print(T type)
        {
            Console.WriteLine(type+"-cap edildi");
        }
    }
}
