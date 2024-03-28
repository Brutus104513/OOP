using System; 

namespace OOP2
{
    public abstract class Array
    {
        public Array(bool not_random_filling){}
        public Array(){}
        protected abstract void Random_filling();
        protected abstract void User_filling();
        public abstract void Array_filling(bool not_random_filling);
        public abstract void Print_array();
        public abstract double Average();
    }
}