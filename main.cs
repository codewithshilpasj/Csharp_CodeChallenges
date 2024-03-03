/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    int new_ascii_in_letter;
    
    Console.WriteLine("Enter the letter");
    char in_letter = Convert.ToChar(Console.ReadLine());
    int ascii_in_letter =  (int)in_letter;
    
    if(ascii_in_letter>=97 & ascii_in_letter<=122 )
    {
              new_ascii_in_letter=ascii_in_letter-32;
              in_letter=(char)new_ascii_in_letter;
               Console.WriteLine("Upper case: " + in_letter);
    }
    else if(ascii_in_letter>=65 & ascii_in_letter<=90)
     Console.WriteLine("Upper case: "+in_letter);
     else
        Console.WriteLine("Not a letter");
  }
}
