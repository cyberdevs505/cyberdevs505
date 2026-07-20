using System;
using System.Collections.Generic;

namespace CyberDevs
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "CyberDevs";
            var location = "Islamabad, Pakistan";
            var specialties = new List<string> { "Android Development", "Game Creation", "Cybersecurity" };

            Console.WriteLine($"🌌 Welcome to the official repository of {name}!");
            Console.WriteLine($"📍 Based in {location}");
            Console.WriteLine("⚡ Our Specialties:");
            foreach (var spec in specialties)
            {
                Console.WriteLine($"  - {spec}");
            }
        }
    }
}
