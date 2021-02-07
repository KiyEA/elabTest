using System;

namespace elab
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayMethod arrayMethod = new ArrayMethod();
           int s = arrayMethod.GetCount(new int[] { 0, 10, 0, 8, 3, 10, 7, 0, 9, 3 });
            Console.WriteLine($"{s}");
        }
    }
}
