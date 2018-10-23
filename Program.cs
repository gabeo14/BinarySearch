using System;

namespace BinarySearch
{
  class Program
  {
    static void Main(string[] args)
    {
      // Set number range (min/max)
      var min = 0;
      var max = 100;
      var input = "";
      // prompt user for number
      System.Console.WriteLine($"Pick a number between {min} and {max}.  Press enter to continue");
      System.Console.ReadLine();
      // pick first guess of user's number
      // ask user if higher or lower than pick
      while (input != "equal")
      {
        System.Console.WriteLine($"Is your number lower, higher, or equal to {(min + max) / 2}");
        // get the user answer (lower/higher/equal)
        input = System.Console.ReadLine();
        // reset number based on user answer
        if (input == "higher")
        {
          //System.Console.WriteLine("LOL");
          min = ((min + max) / 2) + 1;
        }
        else if (input == "lower")
        {
          max = ((min + max) / 2) - 1;
        }
        else if (input == "equal")
        {
          System.Console.WriteLine("GOTCHA BITCH! ᕙ(ಠ‸ಠ‶)ᕗ");
        }
        // repeat until guessed
      }
    }
  }
}
