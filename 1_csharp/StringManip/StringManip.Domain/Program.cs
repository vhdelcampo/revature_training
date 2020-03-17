using System;
using System.Text;
using System.Collections.Generic;

namespace StringManip.Domain
{
  class Program
  {
    static void Main(string[] args)
    {
      String test = "Hello how are you doing today";
      Console.WriteLine("Test String: " + test);
      Console.WriteLine("Number of Characters: " + NumChar(test));
      Console.WriteLine("Number of Vowels: " + NumVowels(test));
      Console.WriteLine("Number of Words: " + NumWords(test));
      Console.WriteLine("Number of Repeat Characters: " + RepeatChar(test));
      Console.WriteLine("String Reversed: " + ReverseString(test));
      Console.WriteLine();
    }

    public static int NumChar(String s)
    {
      int count = 0;
      for (int i = 0; i < s.Length; i++)
      {
        count++;
      }
      return count;
    }

    public static int NumVowels(string s)
    {
      var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
      int count = 0;
      for (int i = 0; i < s.Length; i++)
      {
        if (vowels.Contains(s[i])) {count++;}
      }
      return count;
    }

    public static int NumWords(string s)
    {
      int words = 0;
      for (int i = SkipRepeatSpaces(s, 0); i < s.Length; i++)
      {
        if (s[i] == ' ')
        {
          words++;
        }
      }
      return words;
    }

    public static int SkipRepeatSpaces(string s, int i)
    {
      while (s[i] != ' ')
      {
        i++;
      }
      return i;
    }

    public static int RepeatChar(string s)
    {
      int repeat = 0;
      int[] alphabet = new int[60];
      for (int i = 0; i < s.Length; i++)
      {
        if (char.IsLetter(s[i]))
        {
          alphabet[s[i] - 'A']++;
        }
      }
      foreach(var item in alphabet)
      {
        if (item > 1) {repeat++;}
      }
      return repeat;
    }

    public static string ReverseString(string s)
    {
      StringBuilder sb = new StringBuilder();
      for (int i = s.Length-1; i > 0; i--) 
      {
        sb.Append(s[i]);
      }

      return sb.ToString();
    }

  }
}
