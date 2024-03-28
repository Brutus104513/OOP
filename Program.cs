using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Array[] arrays = new Array[3];
            arrays[0] = new One_D();
            arrays[1] = new Two_D(false);
            arrays[2] = new Gear(false);
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(arrays[i].Average());
                arrays[i].Print_array();
            }
        }
    }
}
