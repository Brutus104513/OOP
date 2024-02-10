using System;

namespace OOP
{
    class Gear
    {
        private bool not_random = false;
        private int[][] array;

        private void Random_filling(int length)
        {
            Random rnd = new Random();
            array = new int[length][];
            for(int i = 0; i < length; i++)
            {
                int _long = rnd.Next(15, 26);
                array[i] = new int[_long];
                for(int j = 0; j < _long; j++)
                {
                    array[i][j] = rnd.Next(-200, 201);
                } 
            }
        }

        private void User_filling(int length)
        {
            Console.WriteLine($"Введите {length} строк, в каждой строке - последовательность чисел через пробел");
            array = new int[length][];
            for(int i = 0; i < length; i++)
            {
                string[] line = Console.ReadLine().Split();
                array[i] = new int[line.Length];
                for(int j = 0; j < line.Length; j++)
                {
                    array[i][j] = int.Parse(line[j]);
                }
            }
        }
        public Gear()
        {
            Random_filling(20);
        }

        public Gear(bool not_random_filling, int length)
        {
            not_random = not_random_filling;
            if(not_random)
            {
                User_filling(length);
            }
            else
            {
                Random_filling(length);
            }
        }

        public double Average()
        {
            double average = 0;
            for(int i = 0; i < array.Length; i++)
            {
                average += Average(i) / array.Length;
            }
            return average;
        }

        public double Average(int index)
        {
            double average = 0;
            for(int i = 0; i < array[index].Length; i++)
            {
                average += array[index][i] * 1.0 / array[index].Length;
            }
            return average;
        }

        public void Modify_array_specifically()
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array[i].Length; j++)
                {
                    if(array[i][j] % 2 == 0)
                    {
                        array[i][j] = i * j;
                    }
                }
            }
        }

        public void Print_array()
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]} ");
                }
                Console.Write("\n");
            }
        }
    }
}