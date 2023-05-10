using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    //Generic means the general form.
    //It doesn't contain any data type.
    //Generic means not a specific to a particular data type.
    //we use <> bracket for placeholders with Type name.
    //TypeName<T> T is your data type parameter.
    //Generic allow us to create a single class or method that can be used with different data type.
    //Advantage: We can reuse our code.
    public class Program
    {
        static void Main(string[] args)
        {
            DemoGenericClass<string> demo = new DemoGenericClass<string>("Bruce");
            demo.Method("string");
            demo.DemoMethod<int>(8);
            demo.DemoMethod<string>("Bruce");

            DemoGenericClass<int> intObject = new DemoGenericClass<int>(8);
            intObject.Method(45);

        }
    }
}
