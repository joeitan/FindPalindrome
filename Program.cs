using System;

namespace FindPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {            
            string input = Console.ReadLine();
            int length = input.Length;
            //Palindrome number will never be found in input string less than 2.
            if(length > 1)
            {
                //check whether the last 2 digit of the number is palindrome (for odd length palindrome index out of bound error) .
                if (input[length-1] == input[length-2])
                {
                    Console.WriteLine(true);
                }
                else
                {
                    bool check = false;
                    for (int i = 1; i < length - 1; i++)
                    {
                        //check whether if it is an even length palindrome
                        if (input[i - 1] == input[i])
                        {
                            check = true;
                        }
                        else if (input[i - 1] == input[i + 1]) //check whether if it is an odd length palindrome
                        {
                            check = true;
                        }
                    }
                    if (check)
                    {
                        Console.WriteLine(true);
                    }
                    else
                    {
                        Console.WriteLine(false);
                    }
                }
                
            }
            else
            {
                Console.WriteLine(false);
            }
            
        }
    }
}
