using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab0Angabe
{
    class Program
    {
        private static List<Album> albums = SampleData.GetSampleAlbums();

        static void Main(string[] args)
        {
            Console.WriteLine("--- Step 1 -------------------------------------");
            RunStep1();
            Console.WriteLine("--- Step 2 -------------------------------------");
            RunStep2();
            Console.WriteLine("--- Step 3 -------------------------------------");
            RunStep3();
            Console.WriteLine("--- Step 4 -------------------------------------");
            RunStep4();
            Console.WriteLine("--- Step 5 -------------------------------------");
            RunStep5();
            Console.WriteLine("--- Step 6 -------------------------------------");
            RunStep6();
            Console.WriteLine("--- Step 7 -------------------------------------");
            RunStep7();
            Console.WriteLine("--- Step 8 -------------------------------------");
            RunStep8();
            Console.WriteLine("--- Step 9 -------------------------------------");
            RunStep9();
            Console.WriteLine("--- Step 10 -------------------------------------");
            RunStep10();
            Console.WriteLine("--- Step 11 -------------------------------------");
            RunStep11();

            Console.WriteLine("Press a key ...");
            Console.ReadKey();
        }

        private static void RunStep1()
        {
            // 1) Get the number of albums with an odd ID

            var query = from album in albums
                        where album.Id % 2 != 0
                        select album.Id;

            // 2) Write the number to the console.
            Console.WriteLine(query.Count());
        }

        private static void RunStep2()
        {
            // 1) Get the first album with title 'Thriller' (if it exists)
            Album a = albums.Where(album => album.Title.Equals("Thriller")).First();


            // 2) Get the number of tracks on the album (if it exists)
            Console.WriteLine(a.Songs.Count);
        }

        private static void RunStep3()
        {
            // 1) Get the titles of all albums with an odd ID
            var titles = albums.Where(album => album.Id % 2 != 0).Select(album => album.Title);

            // 2) Write a generic extension method PrintSequence() of IEnumerable<T> 
            //    that can be used to print a sequence of items to the console
            titles.PrintSequence();


        }


        private static void RunStep4()
        {
            // 1) Order the albums by title in descending order and then select
            //    the first three albums. Print them to the console.
            var query = albums.OrderByDescending(album => album.Title).Take(3);

            query.PrintSequence();

            // 2) Order the albums by ID in ascending order and then skip the first
            //    four; print the remaining album titles to the console
            var query2 = albums.OrderBy(album => album.Id).Skip(4);

            foreach (Album a in query2) Console.WriteLine(a.Title);
        }

        private static void RunStep5()
        {
            // 1) Get the single album by 'Bruce Springsteen'
            var query = albums.Where(album => album.Artist.Equals("Bruce Springsteen")).First();

            // 2) Get names of all songs of the album with a rating greater then 3.
            //    Print the names of the songs.
            var query2 = query.Songs.Where(song => song.Rating > 3).Select(song => song.Title);
            query2.PrintSequence();
        }

        private static void RunStep6()
        {
            // 1) Compute the average rating of all the songs on the fifth album
            //    in the list
            double avg = albums.ElementAtOrDefault(4).Songs.Average(song => song.Rating);

            Console.WriteLine(avg);
            Console.WriteLine();

            // 2) Compute the averages of all albums
            var overallAverage = albums.SelectMany(album => album.Songs).Average(song => song.Rating);
            Console.WriteLine(avg);
            Console.WriteLine(overallAverage);

        }

        private static void RunStep7()
        {
            // 1) Get all the years of the songs on the album with ID = 2.
            //    Make sure there are no duplicate years in the output
        }

        private static void RunStep8()
        {
            // 1) Get all the songs from all the albums 

            // 2) Order the songs first by year descending and then by title ascending

            // 3) Select the titles of the songs and print them

            // 4) Optional: use an anonymous type to select Year and title (and print them)
        }

        private static void RunStep9()
        {
            // 1) Get all songs that contain 'Love' in their title
        }

        private static void RunStep10()
        {
            // 1) Get all album titles where any song on the album has a rating of 4.8 or higher

            // 2) Get all album titles where all songs on the album play for longer than
            //    three minutes
        }

        private static void RunStep11()
        {
            // 1) Group all songs by year
            //    Optional: order the grouping by year descending

            // 2) Iterate over all groups, print the year for each group and 
            //    then the songs for each year ordered by duration ascending
        }
    }

    static class PrintHelper
    {
        public static void PrintSequence<T>(this IEnumerable<T> sequence)
        {
            foreach (T item in sequence) Console.WriteLine(item);

            Console.WriteLine();
        }
        
    }
}
