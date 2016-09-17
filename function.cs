//Calling a function without calling it
//cerner_2^5_2016

using System;
using System.Dynamic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic a = new A();
            a.What();
            Console.ReadKey();
        }

        class A : DynamicObject
        {
            public override bool TryInvokeMember(InvokeMemberBinder binder, Object[] args, out Object result)
            {
                Console.WriteLine("First Hand Foundation !!");
                result = null;
                return true;
            }
        }
    }
}
