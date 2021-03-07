using System;
using System.Collections.Generic;
using System.Text;

namespace EmmaSpit_DSA_Assign1
{
    public interface AbstractDataType<T>
    {
        void SaveArray(T element);

        /// <summary>
        /// Counts the number of times that the element appears in the Bag
        /// </summary>
        /// <param name="element">The element to be counted</param>
        /// <returns>The number of times that the element was found</returns>
        int CountWords(T element);

        

        IEnumerable<T> ListAllElements();
    }
}
