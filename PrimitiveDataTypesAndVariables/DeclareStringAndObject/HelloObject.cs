using System;

class HelloObject
{
    static void Main()
    {
        string word1 = "Hello";
        string word2 = "World";

        object result = word1 + " " + word2;
        string greeting = (string)result;

        Console.WriteLine("The first string word is: {0}\nThe second string word is: {1}\nThe object result is: {2} \nString greeting is: {3}", word1,word2, result,greeting);
    }
}