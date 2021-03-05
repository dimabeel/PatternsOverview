using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.CustomEnumerator
{
    public interface IIterator<T>
    {
        T GetNext();

        bool HasMore();

        void Reset();
    }

    public class ObjectIterator<T> : IIterator<T>
    {
        public ObjectIterator(T[] objects)
        {
            this.objects = objects;
        }

        public T GetNext()
        {
            position++;
            return objects[position];
        }

        public bool HasMore()
        {
            if(position >= objects.Length - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Reset()
        {
            position = -1;
        }

        T[] objects;
        int position = -1;
    }
}
