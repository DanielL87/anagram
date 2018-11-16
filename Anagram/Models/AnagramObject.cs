using System.Collections.Generic;
using System;

namespace Anagram.Models
{
  public class program
    {
    public static void Main()
    {
     List<string> initList = new List<string> {}; 
     List<string> finalList = new List<string> {}; 
     Console.WriteLine("Enter a Word");
     string userWord = Console.ReadLine();
     Console.WriteLine("Enter a word to see if its an anagram");
     string userAnagram = Console.ReadLine();
     initList.Add(userAnagram);
     Console.WriteLine("Would you Like top enter another word?");
     string userAnswer = Console.ReadLine();
     while (userAnswer == "Y" || userAnswer == "y")
        {
            Console.WriteLine("Enter a word to add to the list: ");
            userAnagram = Console.ReadLine();
            initList.Add(userAnagram);
            Console.WriteLine("Do you want to add another word to the list? (Y/N)");
            userAnswer = Console.ReadLine();
        }
     AnagramObject newthing = new AnagramObject();   
      foreach(string listItem in initList){
      if(newthing.IsAnagram(userWord, listItem))
      { 
        finalList.Add(listItem);
      }
    }
      Console.WriteLine("here are your word!");
      foreach(string anagramWords in finalList)
      {
        Console.WriteLine(anagramWords);
      }
    }
  }
  public class AnagramObject
  {
    public bool IsAnagram(string word1, string word2)
      {
          char[] listArray = word2.ToCharArray();
          char[] wordArray = word1.ToCharArray();
          Array.Sort(wordArray);
          Array.Sort(listArray);
          string wordArrayString = string.Join("", wordArray);
          string listArrayString = string.Join("", listArray);
          if(wordArrayString == listArrayString)
          {
            return true;
          } 
          else 
          {
            return false;
          }
        }
   }  
}
  //        public static List<string> GetAll()
  //   {
  //       return _instances;
  //   }
  // }

