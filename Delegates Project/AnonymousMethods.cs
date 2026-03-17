using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Project
{
    public delegate string GreetingsDelegate(string name); //delegate declaration for static method
    class AnonymousMethods
    {

        static void Main()
        {
            GreetingsDelegate obj = delegate (string name)
            {
                return "Hello " + name;
            };
            //creating delegate object for static method
            string str = obj.Invoke("durga"); //calling static method using delegate
            Console.WriteLine(str);
            //creating delegate object for static method using anonymous method
        }
    }
}
      
