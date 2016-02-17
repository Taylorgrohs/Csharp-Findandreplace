using System;

namespace FindReplaceApp
{
  public class TheRocksCookout
  {
    public string Finder(string inputWords, string searchWord, string replaceWord)
    {
      string lowerSearchWord = searchWord.ToLower();
      string[] sentenceArray = inputWords.Split(' ');
      foreach (string word in sentenceArray)
      {
        string lowerWord = word.ToLower();
        if (lowerWord == lowerSearchWord)
        {
          sentenceArray[Array.IndexOf(sentenceArray, word)] = replaceWord;
        }

      }
      string resultSentence = String.Join(" ", sentenceArray);
      return resultSentence;
    }
  }
}
