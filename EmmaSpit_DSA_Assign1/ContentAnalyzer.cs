using System;
using System.Collections.Generic;
using System.Text;

namespace EmmaSpit_DSA_Assign1
{
    class ContentAnalyzer<T> : AbstractDataType<T>
    {
        //Input all the methods - Working 

        private Dictionary<T, int> itemArray =
           new Dictionary<T, int>();       // T is the element that I am storing, int is the number of times that it "appears"

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
                // The element does not exist already
                // The new element has a count of 1
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
                itemArray.Add(element,1);
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

/*
      

          public AbstractDataType<T> Union(AbstractDataType<T> otherBag)
          {
              ContentAnalyzer<T> output = new ContentAnalyzer<T>();

              foreach (T getKey in itemCountDictionary.Keys)
              {
                  // get all elements one by one
                  output.itemCountDictionary.Add(getKey, itemCountDictionary[getKey]);
              }
              // fill up all the elements contained in this dictionary to the output's dictionary

              // add one by one all the elements contained in the other bag
              foreach (T element in otherBag.ListAllElements())
              {
                  output.Add(element);
              }

              return output; // implicit type casting, since BagDS is and IBagADT
         */



