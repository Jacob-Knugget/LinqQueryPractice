using System;
namespace LinqQueryPractice
{
    class Program
    {
        class famousPeople
        {
            public string Name { get; set; }
            public int? BirthYear { get; set; } = null;
            public int? DeathYear { get; set; } = null;
        }

        static void Main(string[] args)
        {
            IList<famousPeople> stemPeople = new List<famousPeople>() {
                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
            };

            var ninetienthCentury = stemPeople.Where(s => s.BirthYear > 1900).OrderByDescending(s => s.Name).ToList<famousPeople>();
            var lowerL = stemPeople.Where(s => s.Name.Contains("ll")).OrderByDescending(s => s.Name).ToList<famousPeople>();
            var lateNinetienthCent = stemPeople.Count(s => s.BirthYear > 1950);
            var between = stemPeople.Where(s => s.BirthYear >= 1920 && s.BirthYear <= 2000).OrderByDescending(s => s.Name).ToList<famousPeople>();
            var birthCount = between.Count();
            var sorted = stemPeople.OrderByDescending(s => s.BirthYear).ToList<famousPeople>();
            var death = stemPeople.Where(s => s.DeathYear > 1960 && s.DeathYear < 2015).OrderBy(s => s.Name).ToList<famousPeople>();

            Console.WriteLine("Born after 1900:\n");
            Display(ninetienthCentury);
            Console.WriteLine("Name Contains ll:\n");
            Display(lowerL);
            Console.WriteLine($"Born after 1950: {lateNinetienthCent}\n");
            Console.WriteLine("Born between 1920 & 2000:\n");
            Display(between);
            Console.Write($"Born between 1920 & 2000: ");
            Console.WriteLine($"{birthCount}\n");
            Console.WriteLine("Sorted by birth year:\n");
            Display(sorted);
            Console.WriteLine("Deaths after 1960 & before 2015:\n");
            Display(death);

            static void Display(List<famousPeople> value) {
                foreach (var i in value)
                {
                    Console.WriteLine($"{i.Name}");
                }
                Console.WriteLine();
            }
        }
    }
}