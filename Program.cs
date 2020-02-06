using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string passPhrase;
            string schoolCheer;
            string songLyrics;
            string nameC1;
            string nameC2;
            string nameC3;
            string nameC4;
            string nameC5;
            string nameC6;
            string nameC7;
            string nameA1;
            string nameA2;
            string nameA3;
            string nameA4;
            string nameA5;
            string nameA6;
            string nameA7;
            string firstName1;
            string Movie;
            string faveMovie;
            string upFaveMovie;
          


            Console.WriteLine("Hello World!");
            firstName = "James";
            Console.WriteLine($"Hello {firstName}");

            passPhrase = "Aldworth";
            Console.WriteLine($"The Phrase {passPhrase} has {passPhrase.Length} Characters");

            //Trim method removes the space from strings

            schoolCheer = "programmers are the best";
            schoolCheer = schoolCheer.ToUpper(); 
            Console.WriteLine(schoolCheer);

            songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));
            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));
            Console.Write(" CCC ");
            Console.WriteLine("   A  ");

            //Console.Write() does not

            nameC1 = " CCC ";
            nameC2 = "C   C";
            nameC3 = "C";
            nameC4 = "C";
            nameC5 = "C";
            nameC6 = "C   C";
            nameC7 = " CCC ";
            nameA1 = "    A ";
            nameA2 = "   A A";
            nameA3 = "      A   A";
            nameA4 = "      AAAAA";
            nameA5 = "      A   A";
            nameA6 = "  A   A";
            nameA7 = "  A   A";
            Console.WriteLine(nameC1 + nameA1);
            Console.WriteLine(nameC2 + nameA2);
            Console.WriteLine(nameC3 + nameA3);
            Console.WriteLine(nameC4 + nameA4);
            Console.WriteLine(nameC5 + nameA5);
            Console.WriteLine(nameC6 + nameA6);
            Console.WriteLine(nameC7 + nameA7);
            Console.Write("Enter Your Name: ");
            firstName1 = Console.ReadLine();
            Movie = ($"Hello {firstName1}, I see that you like the Matrix");
            Movie = Movie.ToLower ();
            Console.WriteLine(Movie);

            Console.Write("Enter Your Favorite Movie: ");
            faveMovie = Console.ReadLine();
            upFaveMovie = faveMovie.ToUpper();
            Console.WriteLine(upFaveMovie.Contains("THE"));
            Console.WriteLine(upFaveMovie.Replace("A", "@"));
            Console.WriteLine(upFaveMovie.Replace("E", "3"));

        }
    }
}
