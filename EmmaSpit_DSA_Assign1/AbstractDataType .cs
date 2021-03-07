using System;
using System.Collections.Generic;
using System.Text;

namespace EmmaSpit_DSA_Assign1
{
    public interface AbstractDataType<T>
    {
        void SaveArray(T element);

        int CountWords(T element);

        void UniqueWords(T element);

        IEnumerable<T> ListAllElements();
    }
}
