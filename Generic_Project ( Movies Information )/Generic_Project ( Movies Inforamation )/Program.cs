using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Project___Movies_Information__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movies<double,DateTime>> firstList = new List<Movies<double,DateTime>>();
            List<Movies<float, int>> SecondList = new List<Movies<float, int>>();

            Movies<double,DateTime> movies= new Movies<double,DateTime>();
            movies.MovieName = "Lord of the rings Part 01";
            movies.DirectorName = "Peter Pattinson";
            movies.Rate = 8.8;
            movies.ReleaseDate = new DateTime(2020, 7, 8);

            Movies<double, DateTime> movies_1 = new Movies<double, DateTime>();
            movies_1.MovieName = "Lord of the rings Part 02";
            movies_1.DirectorName = "Hendry Hawkson";
            movies_1.Rate = 9.2;
            movies_1.ReleaseDate = new DateTime(2023, 3, 6);

            Movies<float, int> movies_2 = new Movies<float, int>();
            movies_2.MovieName = "The Dark Knights Part 01";
            movies_2.DirectorName = "Hannah Jessey";
            movies_2.Rate = 9.2f;
            movies_2.ReleaseDate = 2021;

            Movies<float, int> movies_3 = new Movies<float, int>();
            movies_3.MovieName = "The Dark Knights Part 02";
            movies_3.DirectorName = "James Thomson";
            movies_3.Rate = 7.1f;
            movies_3.ReleaseDate = 2024;

            firstList.Add(movies);
            firstList.Add(movies_1);
            SecondList.Add(movies_2);
            SecondList.Add(movies_3);

            foreach (var it in firstList)
            {
                Console.WriteLine("Movie name is       : "+ it.MovieName);
                Console.WriteLine("Director name is    : " + it.DirectorName);
                Console.WriteLine("Release Date        : " + it.ReleaseDate);
                Console.WriteLine("Rating out of 10 is : " + it.Rate);
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------------");
           
           
            foreach (var it in SecondList)
            {
                Console.WriteLine("Movie name is       : " + it.MovieName);
                Console.WriteLine("Director name is    : " + it.DirectorName);
                Console.WriteLine("Release Date        : " + it.ReleaseDate);
                Console.WriteLine("Rating out of 10 is : " + it.Rate);
                Console.WriteLine();
            }

        }
    }

    class Movies<T,U>
    {
        private string movieName;

        public string MovieName
        {
            get { return movieName; }
            set { movieName = value; }
        }

        private string directorName;

        public string DirectorName
        {
            get { return directorName; }
            set { directorName = value; }
        }

        private T rate;

        public T Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        private U releaseDate;

        public U ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }



    }
}
