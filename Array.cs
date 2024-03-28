using System; 

namespace OOP3
{
    public abstract class Array
    {
        public Array(bool not_random_filling = false)
        {
            Array_filling(not_random_filling);
        }
        protected abstract void Random_filling();
        protected abstract void User_filling();
        public virtual void Array_filling(bool not_random_filling = false)
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
        public abstract void Print_array();
        public abstract double Average();
    }
}