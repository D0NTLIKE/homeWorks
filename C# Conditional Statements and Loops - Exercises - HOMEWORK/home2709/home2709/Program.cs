using System;

class WordPlural
{
    static void Main()
    {
        string word = Console.ReadLine();
        char first = word[word.Length - 1];
        char second = word[word.Length - 2];
        if (first == 'y')
        {
            word = word.Remove(word.Length - 1);
            Console.WriteLine(word + "ies");
        }
        else if (first == 'o' || first == 's' || first == 'x' || first == 'z' || (first == 'h' && second == 'c' || second == 's'))
        {
            Console.WriteLine(word + "es");
        }
        else
        {
            Console.WriteLine(word + "s");
        }
    }
}