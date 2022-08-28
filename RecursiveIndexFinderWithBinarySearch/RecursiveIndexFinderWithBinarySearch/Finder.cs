using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveIndexFinderWithBinarySearch
{
    public class Finder
    {
        public int Find(int[] array, int first, int last, int key)
        {
            int middle = (first + last) / 2;

            if (first > last)
            {
                return first;
            }
            else if (first == last)
            {
                if (key < array[first])
                {
                    return last;
                }
                else
                {
                    return last + 1;
                }
            }
            else if (key == array[middle])
            {
                return middle + 1;
            }
            else if (key > array[middle])
            {
                return Find(array, middle + 1, last, key);
            }
            else
            {
                return Find(array, first, middle - 1, key);
            }
        }
    }
}
