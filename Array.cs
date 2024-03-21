using System; 

namespace OOP2
{
    public abstract class Array
    {
        public Array(bool not_random_filling, int length){}
        public Array(){}
        public abstract void Print_array();
        public abstract double Average();
    }
}