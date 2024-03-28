using System;

namespace OOP3
{
    public sealed class Gear : Array
    {
        private int[][] array;

        protected override void Random_filling()
        {
            Random rnd = new Random();
            int length = rnd.Next(5, 16);
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

        protected override void User_filling()
        {
            Console.WriteLine("Введите количество строк в ступенчатом массиве.");
            int length = int.Parse(Console.ReadLine());
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

        public Gear(bool not_random_filling = false) : base(not_random_filling)
        {
        }

        public override double Average()
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

        public override void Print_array()
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