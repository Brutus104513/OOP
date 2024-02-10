using System;

namespace OOP
{
    class Two_D
    {
        private bool not_random = false;
        private int[,] array;

        private void Random_filling(int height, int width)
        {
            Random rnd = new Random();
            array = new int[height, width];
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    array[i, j] = rnd.Next(-200, 201);
                }
            }
        }

        private void User_filling(int height, int width)
        {
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

        public Two_D()
        {
            Random_filling(20, 20);
        }

        public Two_D(bool not_random_filling, int height, int width)
        {
            not_random = not_random_filling;
            if(not_random)
            {
                User_filling(height, width);
            }
            else
            {
                Random_filling(height, width);
            }
        }

        public void Print_array_normally() 
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

        public double Average()
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

        public int Matrix_determinant_array()
        {
            return Matrix_determinant(array);
        }
    }
}