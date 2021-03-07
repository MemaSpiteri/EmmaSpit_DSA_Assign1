using System;
using System.Collections.Generic;
using System.Text;

namespace EmmaSpit_DSA_Assign1
{
    class ContentAnalyzer<T> : AbstractDataType<T>
    {
        //Input all the methods - Working 

        private Dictionary<T, int> itemArray =
           new Dictionary<T, int>();


        //•ToArray () : T[ ] - saved in array || display from array? 
        public void SaveArray(T element)
        {
            if (itemArray.ContainsKey(element))
            {
                itemArray[element] =
                    itemArray[element] + 1;
            }
            else
            {
                itemArray.Add(element, 1);
            }
        }


        //•CountWords() : int - return int[Tot.words]
        public int CountWords(T element)
        {
            return itemArray[element];
        }


        //Display
        public IEnumerable<T> ListAllElements()
        {
            throw new NotImplementedException();
        }


        //• CountUniqueWords() : int - return int[Tot. uni. words - Remove duplicates]
        public void UniqueWords(T element)
        {
            if (itemArray.ContainsKey(element))
            {
                itemArray.Add(element, 1);
            }
            else
            {
                itemArray[element] =
                    itemArray[element] + 1;

            }
        }
        /*
            • DataSimilarity(T data) :  int - return int[??]
        */
    }
}