using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Project
{
    public delegate double Delegate1(int x, float y, double z); //delegate declaration for static method with return type
    public delegate void Delegate2(int x, float y, double z); //delegate declaration for static method without return type
    public delegate bool Delegate3(string str); //delegate declaration for static method with return type
    class GenericDelegates
    {
        /*public static double AddNums1(int x, float y, double z)
        {
            return x + y + z;
        }*/
        /*public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }*/
        /*public static bool CheckLength(string str)
        {
            if (str.Length > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
         static void Main()
        {
            /*Delegate1 obj1 = AddNums1; //creating delegate object for static method with return type
            double result = obj1.Invoke(10, 20.5f, 30.5); //calling static method using delegate
            Console.WriteLine(result);

            Delegate2 obj2 = AddNums2; //creating delegate object for static method without return type
            obj2.Invoke(10, 20.5f, 30.5); //calling static method using delegate

            Delegate3 obj3 = CheckLength; //creating delegate object for static method with return type
            bool res = obj3.Invoke("durga"); //calling static method using delegate
            Console.WriteLine(res);*/

            /*Func<int, float, double, double> obj1 = (x,y,z)=>
            {
                return x + y + z;
            }; *///Func delegate for static method with return type (or)
            Func<int, float, double, double> obj1 = (x, y, z) =>  x + y + z;
           
            double result = obj1.Invoke(10, 20.5f, 30.5); 
            Console.WriteLine(result);

            Action<int, float, double> obj2 = (x,y,z)=>
            { Console.WriteLine(x + y + z); 
            }; //Action delegate for static method without return type
            obj2.Invoke(10, 20.5f, 30.5); 

            Predicate<string> obj3 = (str)=>
            {
                if (str.Length > 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }; //Predicate delegate for static method with return type (or)
            //Func<string, bool> obj3 = CheckLength; //Func delegate for static method with return type
            bool res = obj3.Invoke("durga");
            Console.WriteLine(res);


        }
        }
    }

