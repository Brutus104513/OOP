using System;

namespace OOP2
{
    public sealed class Two_D : Array
    {
        private bool not_random = false;
        private int[,] array;

        public Two_D()
        {
            Random_filling();
        }

        public Two_D(bool not_random_filling) : base(not_random_filling)
        {
            Array_filling(not_random_filling);
        }

        public override void Array_filling(bool not_random_filling)
        {
            if(not_random_filling)
            {
                User_filling();
            }
            else
            {
                Random_filling();
            }
        }

        protected override void Random_filling()
        {
            Random rnd = new Random();
            int height = rnd.Next(5, 16);
            int width = rnd.Next(5, 16);
            array = new int[height, width];
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    array[i, j] = rnd.Next(-200, 201);
                }
            }
        }

        protected override void User_filling()
        {
            Console.WriteLine("Введите количество строк.");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов.");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine($"Введите {height} строк, в каждой строке - по {width} чисел");
            array = new int[height, width];
            for(int i = 0; i < height; i++)
            {
                string[] line = Console.ReadLine().Split();
                for(int j = 0; j < width; j++)
                {
                    array[i, j] = int.Parse(line[j]);
                }
            }
        }

        public override void Print_array()
        {
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.Write("\n");
            }
        }

        public override double Average()
        {
            double average = 0;
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    average += array[i, j] * 1.0 / array.GetLength(0) / array.GetLength(1);
                }
            }
            return average;
        }

        public void Print_array_with_alternation() 
        {
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if(i % 2 == 0)
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                    else
                    {
                        Console.Write($"{array[i, array.GetLength(1) - j - 1]} ");
                    }
                }
                Console.Write("\n");
            }
        }

        private int Matrix_determinant(int[,] matrix)
        {
            if(matrix.GetLength(0) != matrix.GetLength(1))
            {
                return 0;
            }
            if(matrix.GetLength(0) == 1)
            {
                return array[0, 0];
            }
            int determinant = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                int[,] new_matrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
                for (int j = 0; j < new_matrix.GetLength(0); j++)
                {
                    for (int p = 0; p < new_matrix.GetLength(1); p++)
                    {
                        if (p < i)
                        {
                            new_matrix[j, p] = matrix[j + 1, p];
                        }
                        else
                        {
                            new_matrix[j, p] = matrix[j + 1, p + 1];
                        }
                    }
                }
                determinant += Convert.ToInt32(Math.Pow(-1, i)) * Matrix_determinant(new_matrix) * matrix[0, i];
            }
            return determinant;    
        }

        public int Matrix_determinant_array()
        {
            return Matrix_determinant(array);
        }
    }
}