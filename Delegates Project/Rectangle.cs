using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Project
{
    public delegate void RectDelegate(double width, double Height); //delegate declaration for non static method
    class Rectangle
    {
        public void GetArea(double width, double Height)
        {
            Console.WriteLine("Area of Rectangle is: " + (width * Height));
        }
        public void GetPermiter(double width, double Height)
        {
            Console.WriteLine("Permiter of Rectangle is: " + (2 * (width + Height)));
        }
        static void Main()
        {
            Rectangle rect =new Rectangle();
            
            RectDelegate rectDelegate = new RectDelegate(rect.GetArea); //1st way creating delegate object for non static method
            //RectDelegate = rect.GetArea; //2nd way creating delegate object for non static method using method group conversion
            rectDelegate += rect.GetPermiter;
            rectDelegate.Invoke(5, 10); //calling non static method using delegate
            Console.WriteLine();
            rectDelegate.Invoke(30, 40); //assigning new values will aslo be added to previous values in next line

              //creating delegate object for non static method
            //rect.GetArea(5, 10);
            //rect.GetPermiter(10, 5);
            

        }
    }
}
