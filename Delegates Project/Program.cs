using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Project
{
    //step1: declare delegate
    public delegate void AddDelegate(int a, int b); //delegate declaration for non static method
    public delegate string SayHelloDelegate(string name); //delegate declaration for static method
    public class Program
    {
        public void AddNums(int a, int b) //non static method
        {
            Console.WriteLine(a + b);
        }
        public static string SayHello(string name) //static method
        {
            return "Hello " + name;
        }
        static void Main(string[] args)
        {
            Program p = new Program(); //creating object of Program class to call non static method
            p.AddNums(10, 20); //calling non static method

            AddDelegate addDel = new AddDelegate(p.AddNums); //creating delegate object for non static method
            addDel.Invoke(30, 40); //calling non static method using delegate

            string str= Program.SayHello("Durga"); //calling static method
            Console.WriteLine(str);
            
            SayHelloDelegate sayHelloDel = new SayHelloDelegate(Program.SayHello); //creating delegate object for static method
            string str2 = sayHelloDel("Durga"); //calling static method using delegate
            Console.WriteLine(str);
        }
    }
}
