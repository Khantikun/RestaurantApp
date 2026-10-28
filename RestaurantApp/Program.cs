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
        }
    }

    public class Restaurant
    {
        public int Id { get; set; }           
        public string Name { get; set; }     
        public string Type { get; set; }     
        public double Score { get; set; }
    }
}