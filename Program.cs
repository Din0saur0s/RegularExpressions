using System;
using System.Text.RegularExpressions;

namespace RegularExpressions1
{
  class Program
  {
    static void Main(string[] args)
    { /*
      string[] text ={"Макс",
        "C++",
        " +79263772622",
        " 89263772622",
        " (926)3772622" };

      foreach (string item in text)
      {
        string pattern = @"\d{7}";
        if (Regex.IsMatch(item, pattern))
        {
          //Console.WriteLine($"{item} это телефон"); 
          Console.WriteLine(item + " это телефон");
        }
        else
        {
          Console.WriteLine(
          string.Format("{0} это НЕ телефон", item)
          );
        }

      }

    }     */

      string[] text ={ "(555)555-1212", "(555) 555-1212", "555-555-1212", "5555551212", "01111", "01111-1111", "47", "111-11-1111" };

      static bool IsPhone(string s)
      {
        return Regex.IsMatch(s, @"^\(?\d{3}\)?[\s\-]?\d{3}\-?\d{4}$");
      }

      static bool IsZip(string s)
      {
        return Regex.IsMatch(s, @"^\d{5}(\-\d{4})?$");
      }

      foreach (string s in text)
      {
        if (IsPhone(s)) Console.WriteLine(s + " is a phone number");
        else if (IsZip(s)) Console.WriteLine(s + " is a zip code");
        else Console.WriteLine(s + " is unknown");
      }


      }


    }
  }
