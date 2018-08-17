using System;


namespace AliceInWonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            //The first sentence of Alice in Wonderland is below.  Store this sentence in a string, and then prompt the 
            //user for a string to search for within this string.  Print whether the search term was foun.
            //See if you can make the search case-insensitive, so that searching for "alice" prints TRUE

            //Alice was beginning to get vey tired of sitting  by her sister on the bank and of having nothing to do:
            //once or twice she had peeped into the book her siyer was reading, but it had no pictures or conversations in it, 
            //'and what is the use of a book,' thought Alice 'without pictures or conversation ?'

            Console.WriteLine("Please enter any word and this program will search in " + "the phrase below for that word.\n");
            string myString = "Alice was beginning to get very tired of sitting  by her sister on the bank and of having nothing to do: " +
                              "once or twice she had peeped into the book her sister was reading, but it had no pictures or " +
                              "conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation ?'\n ";

            //string uppermyString = myString.ToUpper();

            Console.WriteLine(myString);
            Console.WriteLine("Enter the word to be searched");

            string input = Console.ReadLine();
           // string upperInput = input.ToUpper();
            var start = myString.ToUpper().IndexOf(input.ToUpper());

            if (start >= 0)
            {
                Console.WriteLine("Your word is in phrase " + start);
            }
            else
            {
                Console.WriteLine("You lose");
            }
                
                                            
                   
            Console.ReadLine();
        }
    }
}
