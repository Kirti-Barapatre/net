using System;
using System.Collections.Generic;
using System.Text;

namespace programday1
{
    //by default access specifier for class is internal
    class ArrayEg
    {
        //by default access specifier for member and member function is private

        //single dimensional array
        //datatype[] arrayname= new datatype[size];
        string[] fruits = new string[3];
        int[] mark = { 89, 78, 90 };

        internal void GetFruits()
        {
            for(int i=0;i<fruits.Length;i++)
            {
                Console.WriteLine("Enter the fruitname");
                fruits[i] = Console.ReadLine();
            }

            //foreach(string fu in fruits)
            //implicity typed variable
            foreach( var fu in fruits)
            {
                Console.WriteLine("FruitName:{0}", fu);
            }
        }
    }

    class StringEg
    {
        internal void StringFunction()
        {
            string Firstname = "SAI";
            string Name = "KIRTI BARAPATRE";
            Console.WriteLine("TO UPPER :{0}", Firstname.ToUpper());
            Console.WriteLine("TO LOWER :{0}", Firstname.ToLower());
            Console.WriteLine("LENGTH:{0}", Name.Length);
            bool isContains = Name.Contains("RT");
            Console.WriteLine("Contains RT:{0}", isContains);
            Console.WriteLine("Substring : {0}", Name.Substring(3, 5));

        }
    }

    class Array_Static
    {
        static void Main()
        {
            ArrayEg arrayEg = new ArrayEg();
            arrayEg.GetFruits();

            StringEg stringEg = new StringEg();
            stringEg.StringFunction();
        }
    }
}
