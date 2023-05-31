using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGenericClass
{
    public class Guarda3<T>
    {
        private T slot0;
        private T slot1;
        private T slot2;

        public Guarda3()
        {
            slot0 = default;
            slot1 = default;
            slot2 = default;
        }

        public T GetItem(int i)
        {
            switch (i)
            {
                case 0: return slot0;
                case 1: return slot1;
                case 2: return slot2;
                default: throw new IndexOutOfRangeException();
            }
        }

        public void SetItem(int i, T item)
        {
            switch (i)
            {
                case 0:
                    slot0 = item;
                    break;
                case 1:
                    slot1 = item;
                    break;
                case 2:
                    slot2 = item;
                    break;
                default: throw new IndexOutOfRangeException();
            }
        }



    }
}