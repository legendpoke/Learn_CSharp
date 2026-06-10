using System;
using System.Collections.Generic;
using System.Text;

namespace C__Course
{
    class conditional_statements {
        static void Conditional(string[] args) {
            int marks = 89;
            if (marks < 100 && marks >= 90) { 
                Console.WriteLine("Grade A"); 
            }
            else if (marks < 90 && marks >= 80) { 
                Console.WriteLine("Grade B"); 
            }
            else if (marks < 80 && marks >= 70) { 
                Console.WriteLine("Grade C"); 
            }
            else if (marks < 70 && marks >= 60) { 
                Console.WriteLine("Grade D"); 
            }
            else { 
                Console.WriteLine("Grade F"); 
            }
        }
    }
}
