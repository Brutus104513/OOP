using System;

namespace OOP3
{
    public sealed class One_D : Array
    {
        private int[] array;

        public One_D(bool not_random_filling = false) : base(not_random_filling){}

        protected override void Random_filling()
        {
            Random rnd = new Random();
            int length = rnd.Next(5, 16);
            array = new int[length];
            for(int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(-200, 201);
            }
        }

        protected override void User_filling()
        {
            Console.WriteLine("Введите длину одномерного массива");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine($"Введите {length} чисел построчно");
            array = new int[length];
            for(int i = 0; i < length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        public override void Print_array()
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.Write("\n");
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

        public override double Average()
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