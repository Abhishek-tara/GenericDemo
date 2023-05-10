using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class DemoGenericClass<T>
    {
        //variable of type T
        public T data;

        //Generic constructor
        public DemoGenericClass(T data)
        {
            this.data = data;
            Console.WriteLine("Data :" + this.data);
        }
        
        public void Method(T data)
        {
            Console.WriteLine("Data :" + data);
        }
        //Generic Method
        public void DemoMethod<T>(T data)
        {
            Console.WriteLine("Generic Data :" + data);
        }
    }
}
