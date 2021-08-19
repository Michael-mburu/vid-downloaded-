using System;
using System.Diagnostics;
using Sheller;
namespace vid_downloaded
{
    class Program
    {
        static void Main(string[] args)
        {
            // main entry enter
            Console.WriteLine("Enter video url:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();
           Process p= Process.Start("C:\\Users\\nasty michael\\source\\repos\\vid-downloaded\\vid-downloaded\\youtube-dl.exe" ,userName);
      
            // Print the value of the variable (userName), which will display the input value

        }

   
    }
}

