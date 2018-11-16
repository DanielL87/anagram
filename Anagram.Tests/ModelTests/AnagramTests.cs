using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System.Collections.Generic;
using System;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTests
  {

    [TestMethod]
    public void IsAnagram_CompareWords_True()                
    {
      // Arrange
      string word1 = "ready";
      string word2 = "deary";

      List<string> newList = new List<string> {"deary is an anagram."};

      AnagramObject newAnagram = new AnagramObject(word1, word2);

      // Act
      object result = newAnagram.IsAnagram();
      // Assert
      Assert.AreEqual(newList, result);
    }
  }
}