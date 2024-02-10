using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой массив ВЫ хотите создать, одномерный, двумерный или зубчатый?");
            string array_type = Console.ReadLine();
            if (array_type == "одномерный")
            {
                Console.WriteLine("Введите длину массмва");
                int length = int.Parse(Console.ReadLine());
                Console.WriteLine("Заполнить рандомно, да или нет?");
                string random = Console.ReadLine();
                bool not_random_filling = random == "да" ? false : true;
                One_D array = new One_D(not_random_filling, length);
                Console.WriteLine("Теперь вводите команды: 0 - завершение работы программы; 1 - среднее арифметическое элементов массива; 2 - удаление из массива элементов, больших 100 по модулю; 3 - массив без повторяющихся элементов; 4 - распечатать массив");
                int answer = int.Parse(Console.ReadLine());
                while(answer != 0)
                {
                    switch(answer)
                    {
                        case 1:
                            Console.WriteLine(array.Average());
                            break;
                        case 2:
                            array.Remove_elements_modulo_greater_than_100();
                            break;
                        case 3:
                            array.Array_without_repetitions();
                            break;
                        case 4:
                            array.Print_array();
                            break;
                    }
                    answer = int.Parse(Console.ReadLine());
                }
            }
            else if (array_type == "двумерный")
            {
                Console.WriteLine("Введите кол-во строк и столбцов в массиве");
                int height = int.Parse(Console.ReadLine());
                int width = int.Parse(Console.ReadLine());
                Console.WriteLine("Заполнить рандомно, да или нет?");
                string random = Console.ReadLine();
                bool not_random_filling = random == "да" ? false : true;
                Two_D array = new Two_D(not_random_filling, height, width);
                Console.WriteLine("Теперь вводите команды: 0 - завершение работы программы; 1 - среднее арифметическое элементов массива; 2 - распечатать массив змейкой; 3 - определитель матрицы; 4 - распечатать массив");
                int answer = int.Parse(Console.ReadLine());
                while(answer != 0)
                {
                    switch(answer)
                    {
                        case 1:
                            Console.WriteLine(array.Average());
                            break;
                        case 2:
                            array.Print_array_with_alternation();
                            break;
                        case 3:
                            Console.WriteLine(array.Matrix_determinant_array());
                            break;
                        case 4:
                            array.Print_array_normally();
                            break;
                    }
                    answer = int.Parse(Console.ReadLine());
                }
            }
            else if (array_type == "зубчатый")
            {
                Console.WriteLine("Введите кол-во вложенных массивов");
                int length = int.Parse(Console.ReadLine());
                Console.WriteLine("Заполнить рандомно, да или нет?");
                string random = Console.ReadLine();
                bool not_random_filling = random == "да" ? false : true;
                Gear array = new Gear(not_random_filling, length);
                Console.WriteLine("Теперь вводите команды: 0 - завершение работы программы; 1 - среднее арифметическое элементов массива; 2 - среднее арифметическое элементов вложенного массива; 3 - заменить четные по значению элементы массива на произведение индексов; 4 - распечатать массив");
                int answer = int.Parse(Console.ReadLine());
                while(answer != 0)
                {
                    switch(answer)
                    {
                        case 1:
                            Console.WriteLine(array.Average());
                            break;
                        case 2:
                            Console.WriteLine("Введите индекс вложенного массива");
                            int index = int.Parse(Console.ReadLine());
                            Console.WriteLine(array.Average(index));
                            break;
                        case 3:
                            array.Modify_array_specifically();
                            break;
                        case 4:
                            array.Print_array();
                            break;
                    }
                    answer = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}