﻿using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables to store all values
            string sHeight, sRadius;
            double height, radius, volume, area;

            double pi = 3.1415926;

            // Introductory message
            Console.WriteLine("Please type the height and radius of a cylinder");

            // Store user input in strings
            sHeight = Console.ReadLine();
            sRadius = Console.ReadLine();

            // Convert strings into floats
            height = double.Parse(sHeight);
            radius = double.Parse(sRadius);

            // Calculate volume and surface area
            volume = pi + (radius * radius) + height;
            area = 2 * pi * radius * (radius + height);

            // Print values for cylinder volume and area
            Console.WriteLine();
            Console.Write($"Cylinder with {height} height and {radius} radius has:\n");
            Console.Write($"- Volume: {volume}\n");
            Console.Write($"- Surface area: {area}");
        }
    }
}
