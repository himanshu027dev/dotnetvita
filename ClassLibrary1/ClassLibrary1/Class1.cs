using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Mycalculatorlib

{
    //creat a class library mycalculator with two methods 1.public int sqr(intx) 2.internal void dojob
    public class calculatorlib
    {
        public int sqr(int x)
        {
            return x * x;
        }
        internal void dojob()
        {
            Console.WriteLine("doing jobs");
        }
    
    }
}
