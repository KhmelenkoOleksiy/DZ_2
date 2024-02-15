using DZ_2;
using DZ_2.Classes;
using System.Security.Cryptography.X509Certificates;

namespace DZ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Apple", "Banana", "Orange", "Avokado", "Grapes", "Pineapple", "Kumquat" };
            var FilterWords = words.Where(word => word.StartsWith("A", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("First task");

            foreach (var word in FilterWords) 
            {
               Console.WriteLine(word);
            }

            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] array2 = { 12, 3, 9, 71, 11, 4, 18, 35, 2, 13, 1 };

            var commonValues = array1.Intersect(array2);

            Console.WriteLine("\nSecond task");

            foreach (var value in commonValues)
            {
            Console.WriteLine(value);
            }

            List<Student> students = new List<Student>

                {
                    new Student {
                    Name = "Matt",
                    SurName = "LeBlanv",
                    Grade = 63
                    },
                    new Student {
                    Name = "Jennifer",
                    SurName = "Aniston",
                    Grade = 93
                    },
                    new Student {
                    Name = "Courteney",
                    SurName = "Cox",
                    Grade = 75
                    },
                    new Student {
                    Name = "Lisa",
                    SurName = "Kudrow",
                    Grade = 81
                    },
                    new Student {
                    Name = "Matthew",
                    SurName = "Perry",
                    Grade = 99
                    }
                };
            var studentWithMaxGrade = students.OrderByDescending(s => s.Grade).First();
            Console.WriteLine($"\nThird task  \n{studentWithMaxGrade.Name}  {studentWithMaxGrade.SurName}  \nGrade  {studentWithMaxGrade.Grade}");

            List<Product> products = new List<Product>
            {
                new Product
                {
                    Title = "Macbook",
                    Price = 1200,
                    Category = "Electronics"
                },
                new Product
                {
                    Title = "SmartPhone",
                    Price = 800,
                    Category = "Electronics"
                },
                new Product
                {
                    Title = "TV",
                    Price = 600,
                    Category = "Electronics"
                },
                new Product
                {
                    Title = "Dumbbell",
                    Price = 400,
                    Category = "Sport"
                },
                new Product
                {
                    Title = "Bike",
                    Price = 1000,
                    Category = "Sport"
                },
                new Product
                {
                    Title = "Ball",
                    Price = 200,
                    Category = "Sport"
                }

            };
            var averagePricesByCategory = products.GroupBy(product => product.Category).Select(group => new
            {
                Category = group.Key,
                AveragePrice = group.Average(price => price.Price)
            });

            Console.WriteLine("\nFourth task");
            
            foreach ( var result in averagePricesByCategory )
            {
                Console.WriteLine($"Category: {result.Category}, Average Price: {result.AveragePrice:0.00} $");
            }

            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Name = "Bred",
                    SurName = "Pit",
                    BirthDate = new DateTime(1984, 3, 14),
                    EmploymentDate = new DateTime(2022, 8, 1)
                },
                 new Employee
                {
                    Name = "Deni",
                    SurName = "De Vito",
                    BirthDate = new DateTime(1967, 7, 5),
                    EmploymentDate = new DateTime(2008, 2, 11)
                },
                  new Employee
                {
                    Name = "Mark",
                    SurName = "Wahlberg",
                    BirthDate = new DateTime(1975, 10, 25),
                    EmploymentDate = new DateTime(2020, 4, 15)
                },
                   new Employee
                {
                    Name = "Dwayne",
                    SurName = "Johnson",
                    BirthDate = new DateTime(1972, 5, 2),
                    EmploymentDate = new DateTime(2016, 12, 30)
                },
            };
            var LongTermEmployees = employees.Where(employee => (DateTime.Now - employee.EmploymentDate).TotalDays > (5 * 365));
            Console.WriteLine("\nFifth task");
            foreach (var employee in LongTermEmployees)
            {
                Console.WriteLine($"{employee.Name} {employee.SurName} Employment Date: {employee.EmploymentDate.ToShortDateString()}");
            }

            List<Book> books = new List<Book>
            {
                new Book
                {
                    Title = "Harry Potter and the Cursed Child",
                    Author = "Joanne Rowling",
                    PublicationYear = 2016,
                    Genre = "Fantasy"
                },
                new Book
                {
                    Title = "Duna",
                    Author = "Frenk Gerbert",
                    PublicationYear = 1965,
                    Genre = "Fantasy"
                },
                new Book
                {
                    Title = "Murder on the Orient express",
                    Author = "Agata Kristi",
                    PublicationYear = 1933,
                    Genre = "Detective"
                },
                new Book
                {
                    Title = "Sherlock Holms",
                    Author = "Artur Conan Doyle",
                    PublicationYear = 1987,
                    Genre = "Detective"
                }
            };

            var sciFiBooksAfter2010 = books.Where(book => book.Genre == "Fantasy" && book.PublicationYear > 2012);
            Console.WriteLine("\nSixth task");

            foreach (var book in sciFiBooksAfter2010) 
            {
                Console.WriteLine($"{book.Title} by {book.Author}, Published in {book.PublicationYear}");
            }

            List<Customer> customers = new List<Customer>
            {
                new Customer
                {
                    Name = "Alisa",
                    SurName = "Ivanova",
                    Address = "Tverskaya 15A",
                    Orders = new List<decimal> {235, 320, 580}
                },
                new Customer
                {
                    Name = "Maxim",
                    SurName = "Strelkov",
                    Address = "Ostrovskogo 36B",
                    Orders = new List<decimal> {60, 40, 220, }
                },
                new Customer
                {
                    Name = "Janna",
                    SurName = "Dark",
                    Address = "Hreschatik 1",
                    Orders = new List<decimal> {180, 190, 699}
                },
            };

            var highValueCustumers = customers.Where(customer => customer.Orders.Sum() > 1000);
            Console.WriteLine("\nSeventh task");

            foreach(var customer in highValueCustumers)
            {
                Console.WriteLine($"\n{customer.Name} {customer.SurName}, Address: {customer.Address}");
                Console.WriteLine("Orders:");
                foreach(var order in customer.Orders) 
                {
                    Console.WriteLine($"- {order:0.00}$" );
                }
            }
        }
    }
}
