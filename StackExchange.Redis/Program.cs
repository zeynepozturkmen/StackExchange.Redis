using System;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace StackExchange.Redis
{
    public class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var redis = ConnectionMultiplexer.Connect("localhost");
            //var db = redis.GetDatabase();

            //string value = db.StringGet("admin");
            //Console.WriteLine(value);

            //Console.ReadKey();

            //Serilaize
            //var redis = ConnectionMultiplexer.Connect("localhost");
            //var db = redis.GetDatabase();

            //var person = new Person { Name = "Ali", SurName = "Veli" };
            //var jsonified = JsonConvert.SerializeObject(person);

            //db.StringSet("person:1", jsonified);

            //Console.ReadKey();

            //Deserilaze
            var redis = ConnectionMultiplexer.Connect("localhost");
            var db = redis.GetDatabase();

            var readPersonJsonified = db.StringGet("person:1");
            var person = JsonConvert.DeserializeObject<Person>(readPersonJsonified);

            Console.WriteLine("person name:" + person.Name);

            Console.ReadLine();
        }
    }
}
