using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Khantikun");
            Console.WriteLine("Week 2");
            Console.WriteLine("-----------------------");


            List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
                new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
                new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7)
            };

            Console.WriteLine("รายชื่อร้านอาหารทั้งหมด");
            foreach (var item in restaurants)
            {
                Console.WriteLine($"ID: {item.Id} | ร้าน: {item.Name} | ประเภท: {item.Type} | คะแนน: {item.Score}");
            }
        }
    }

    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Score { get; set; }

        public Restaurant(int id, string name, string type, double score)
        {
            Id = id;
            Name = name;
            Type = type;
            Score = score;
        }
    }
}