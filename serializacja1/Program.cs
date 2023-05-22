using System.Net.Mail;

namespace serializacja1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person("Maria", 25, "maria@example.com"),
                new Person("Alex", 43, "alex@example.com"),
                new Person("Oana", 33, "oana@example.com")
            };
            List<Person> people2 = new List<Person>();

            string directory = "directory.csv";
            SerializeToCSV(people, directory);
            DeserializeFromCSV(directory,people2);

            foreach (Person person in people2) { Console.WriteLine( person.ToString()); }
        }
        public static void SerializeToCSV(List<Person> p, string directory)
        {
            using (var writer = new StreamWriter(directory))
            {
                writer.WriteLine("Name,Age,E-Mail");


                foreach (var person in p)
                {
                    writer.WriteLine($"{person.Name},{person.Age},{person.Email}");
                }
            }
        }
        public static List<Person> DeserializeFromCSV(string directory, List<Person> p2)
        {
            //List<Person> p2 = new List<Person>();
            using(var reader = new StreamReader(directory)) 
            {
                reader.ReadLine();

                while (!reader.EndOfStream) 
                {var line = reader.ReadLine();
                    var values = line.Split(',');

                    var person = new Person { Name = values[0], Age = int.Parse(values[1]), Email = values[2] };
                    p2.Add(person);
                }
            return p2;
            }
        }
    }
    }

    