using System;

namespace elab
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayMethod arrayMethod = new ArrayMethod();
           int s = arrayMethod.GetCount(new int[] {4,4,5,8,5,3,6 });
            Console.WriteLine($"{s}");
        }
    }
}
