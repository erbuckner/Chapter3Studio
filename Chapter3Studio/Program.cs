using System;
using System.Collections.Generic;

namespace Chapter3Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            //initilize string
            string stringInput = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            //Turn string into array of characters
            char[] charactersInString = stringInput.ToCharArray();

            Console.WriteLine(charactersInString);

            //initialize Dictionary
            Dictionary<char, int> charDictionary = new Dictionary<char, int>();

            //Loop through array - if value at index isn't a Dictionary key, make it one and give it a value of 1. If it is already a key, add one to the value 
            for (int i = 0; i < charactersInString.Length; i++)
            {
                if (charDictionary.ContainsKey(charactersInString[i]))
                {
                    charDictionary[charactersInString[i]]++;
                }
                else
                {
                    charDictionary.Add(charactersInString[i], 1);
                }
            }

            foreach (KeyValuePair<char, int> i in charDictionary)
            {
                Console.WriteLine("Key: {0}, Value: {1}", i.Key, i.Value);
            }
        }
    }

}
