using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class Functions {
    public  int add(int a, int b) {
        return a + b;
    }
}

namespace C__Course
{
    class Program_three {
        static void Functions(string[] args) {
            Functions f1 = new Functions();
            int result = f1.add(1, 2);
            Console.WriteLine(result);
        }
    }
}
