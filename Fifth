using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first Word: ");
        string W1 = Console.ReadLine();

        Console.WriteLine("Enter the second Word: ");
        string W2 = Console.ReadLine();

        if (AreAnagrams(W1, W2))
        {
            Console.WriteLine("They are anagrams.");
        }
        else
        {
            Console.WriteLine("They aren't anagrams.");
        }

        Console.ReadLine();
    }

    static bool Anagrams(string W1, string W2)
    {
        if (W1.Length != W2.Length)
        {
            return false;
        }

        char[] charW1 = W1.ToLower().ToCharArray();
        char[] charW2 = W2.ToLower().ToCharArray();

        Array.Sort(charW1);
        Array.Sort(charW2);

        for (int i = 0; i < charW1.Length; i++)
        {
            if (charW1[i] = charW2[i])
            {
                return true;
            }
        }

        return false;
    }
}
