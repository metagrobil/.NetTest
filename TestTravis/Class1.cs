using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestTravis
{
    public class Class1
    {
        int i;
        public Class1()
        {
            Console.Write("Class1");
            Console.Write("Class1");
            File.ReadAllLines("fdfs.txt");
            i =+ 1;
        }
    }
}