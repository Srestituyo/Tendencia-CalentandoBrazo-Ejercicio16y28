using System;

namespace CalentandoBrazos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("16. Vector (x,y) yComponent : Vector");
            Console.Write("Escribe el valor del Vector X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escribe el valor del Vector Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int[] aArray = { x,y };
            OppositeVectorCoordinates(aArray);


            Console.WriteLine("28. Count a number of vowels and consonants in a String:");
            Console.Write("Escribe una oracion o palabra: ");
            var aSentence = Console.ReadLine();

            CountVowelsAndConsonant(aSentence);


            Console.ReadKey();
        }

    

        public static void CountVowelsAndConsonant(string theSentence)
        {
            int aVowelCounter = 0;
            int aConsonantCounter = 0;
            if (theSentence.Length > 0)
            {
                for (int x = 0; x < theSentence.Length; x++)
                {
                    if (theSentence[x] == 'a' || theSentence[x] == 'e' || theSentence[x] == 'i' || theSentence[x] == 'o' || theSentence[x] == 'u')
                    {
                        aVowelCounter++;
                    }
                    else if (!string.IsNullOrWhiteSpace(theSentence[x].ToString()))
                    {
                        aConsonantCounter++;
                    }
                }
            }

            Console.WriteLine($"{aVowelCounter} vowels and {aConsonantCounter} consonants");
        }

        public static void OppositeVectorCoordinates(int[] theVector)
        {
            foreach (var aVector in theVector)
            {
                Console.Write("Vector inicial: " + aVector + ",");
            }
            
            if (theVector.Length > 0)
            {
                for (int x = 0; x < theVector.Length; x++)
                {
                    theVector[x] = theVector[x] * -1;
                }
            }

            foreach (var aVector in theVector)
            {
                Console.Write("Vector Opuesto: " + aVector + ",");
            }
        }
    }
}
