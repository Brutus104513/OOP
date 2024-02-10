using System;

namespace OOP
{
    class One_D
    {
        private bool not_random = false;
        private int[] array;

        private void Random_filling(int length)
        {
            Random rnd = new Random();
            array = new int[length];
            for(int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(-200, 201);
            }
        }

        private void User_filling(int length)
        {
            Console.WriteLine($"Введите {length} чисел построчно");
            array = new int[length];
            for(int i = 0; i < length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        private int Minimum(int[] _array)
        {
            int minimum = _array[0];
            for(int i = 0; i < _array.Length; i++)
            {
                if(minimum > _array[i])
                {
                    minimum = _array[i];
                }
            }
            return minimum;
        }

        private int Maximum(int[] _array)
        {
            int maximum = _array[0];
            for(int i = 0; i < _array.Length; i++)
            {
                if(maximum < _array[i])
                {
                    maximum = _array[i];
                }
            }
            return maximum;
        }

        private bool Find(int[] _array, int number, int border)
        {
            for(int i = 0; i < border; i++)
            {
                if(_array[i] == number)
                {
                    return true;
                }
            }
            return false;
        }

        public One_D()
        {
            Random_filling(20);
        }

        public One_D(bool not_random_filling, int length)
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

        public void Print_array() 
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.Write("\n");
        }

        public double Average()
        {
            double average = 0;
            for(int i = 0; i < array.Length; i++)
            {
                average += array[i] * 1.0 / array.Length;
            }
            return average;
        }

        public void Remove_elements_modulo_greater_than_100()
        {
            int counter = 0; 
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] >= -100 && array[i] <= 100)
                {
                    counter++;
                }
            }
            int[] new_array = new int[counter];
            counter = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] >= -100 && array[i] <= 100)
                {
                    new_array[counter] = array[i];
                    counter++;
                }
            }
            array = new_array;
        }
        public void Array_without_repetitions()
        {
            int counter = 0;
            for(int i = Minimum(array); i < Maximum(array) + 1; i++)
            {
                if(Find(array, i, array.Length))
                {
                    counter++;
                }
            }
            int[] new_array = new int[counter];
            counter = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(!Find(new_array, array[i], counter))
                {
                    new_array[counter] = array[i];
                    counter++;
                }
            }
            array = new_array;
        }
    }
}