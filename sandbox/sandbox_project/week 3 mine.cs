using System;

public class Programs
{
    static void Mains(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        Console.WriteLine("Hello Sandbox World!");
        var x = FindPairs(new string[] { "am", "at", "ma", "if", "fi" });
        Console.WriteLine(string.Join(", ", x));
        
        
    }   
   
    public static string[] FindPairs(string[] words)
    {   
        var pairs = new HashSet<string>();
        foreach (string word in words)
        {   char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr);
            if (words.Contains(reversed) && word != reversed)
            {
                pairs.Add($"{word} & {reversed}");
            }
        }
        // TODO Problem 1 - ADD YOUR CODE HERE
        return pairs.ToArray();
    }

    public static bool IsAnagram(string word1, string word2)
    {   
        word2=word2.ToLower();
        if (word1.Length == word2.Length)
        {
          foreach (char character in word1.ToLower())
          {
            if (!word2.Contains(character))
            {
              return false;
            }
          }
          return true;

        }
        else
        {
            return false;
        }
    }



}