using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Delegates_Project
{
     class LambdaExpressions
    {
       
        static void Main()
        {
            GreetingsDelegate obj =  (name) =>
            {
                return "Hello" + name;
            };
            //creating delegate object for static method
            string str=obj.Invoke("durga"); //calling static method using delegate
            Console.WriteLine(str);

        }
    }
}
