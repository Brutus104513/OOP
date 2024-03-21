using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Array[] arrays = new Array[3];
            arrays[0] = new One_D(false, 5);
            arrays[1] = new Two_D(false, 6, 7);
            arrays[2] = new Gear(false, 3);
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(arrays[i].Average());
                arrays[i].Print_array();
            }
        }
    }
}
