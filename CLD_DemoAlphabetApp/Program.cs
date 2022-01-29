using System;

namespace CLD_DemoAlphabetApp
{
     public class Program
    {
        static void Main(string[] args)
        {
            PrintNormalAlphabet();

            PrintReverseAlphabet();

            PrintAlphabetSkip();


        }

        static void PrintNormalAlphabet() //this prints the alphabet from A to Z
        {
            string alphabet = string.Empty;
            for (char alpha = 'A'; alpha <= 'Z'; alpha++) 
                // as long as Alpha is less than or equal to Z, the loop will increment (by one) and adds each letter to the heap
                // until it reaches Z
            {
                alphabet += alpha; 

            }

            Console.WriteLine(alphabet);
        }

        static void PrintReverseAlphabet() // this prints the alphabet backwards
        {
            string alphabet = string.Empty;
            for (char alpha = 'Z'; alpha >= 'A'; alpha--) // -- is a decremental operator, as this for loop goes through the loop from Z to A
                                                          // in the exact reverse order, as long as Alpha is 'more than or equal to' the letter A
            {
                alphabet += alpha;
            }

            Console.WriteLine(alphabet);
        }

        static void PrintAlphabetSkip() //this prints the alphabet while skipping every other letter
        {
            string alphabet = string.Empty;
            for (char alpha = 'A'; alpha <= 'Z'; alpha = (char)(alpha + 2)) 
                // as long as alpha is less than or equal to Z, alpha 'jumps' two indexes
                                                  
            {
                alphabet += alpha;
            }

            Console.WriteLine(alphabet);
        }

    }
}
