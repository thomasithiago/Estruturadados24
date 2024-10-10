using System;
using System.Collections;

namespace ProductLocation
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating and initializing a dictionary
            Dictionary<string, string> productLocations = new Dictionary<string,string>
            {
                // Adding key-value pairs to the dictionary
                {"89", "A1"},
                {"90", "A2"},
                {"91", "A3"},
                {"92", "A4"},
                {"93", "A5"},
                {"94", "A6"},
                {"95", "A7"},
                {"96", "A8"},
                {"97", "A9"}

            };

            // Adding a new key-value pair to the dictionary
            productLocations["101"] = "B1";
            productLocations["102"] = "B2";
            productLocations["103"] = "B3";
            productLocations["104"] = "B4";
            productLocations["105"] = "B5";
            productLocations["106"] = "B6";
            productLocations["107"] = "B7";
            productLocations["108"] = "B8";
            productLocations["109"] = "B9";

            try
            {
                // Adding a key-value pair to the dictionary with a different method 
                productLocations.Add("205", "C1");
                productLocations.Add("206","C2");
                productLocations.Add("207","C3");
                productLocations.Add("208","C4");
                productLocations.Add("209","C5");
                productLocations.Add("210","C6");
                productLocations.Add("211","C7");
                productLocations.Add("212","C8");
                productLocations.Add("213","C9");
            }
            catch (ArgumentException)
            {
                // If the key already exists, catch the exception and display a message
                Console.WriteLine("Product already exists!");
            }

            Console.WriteLine("All Products: ");

            // If there are no products, display a message
            if(productLocations.Count == 0)
            {
                Console.WriteLine("No products found!");
            }

            else
            {
                // Iterate through the dictionary and display the key-value pairs
                foreach (KeyValuePair<string, string> product in productLocations)
                {
                    Console.WriteLine($"Product ID: {product.Key}, Location: {product.Value}");
                }
            }

            Console.WriteLine();

            // Search manually for a product with the ID
            Console.WriteLine("Procure o produto pelo ID: ");
            string productId = Console.ReadLine();

            if(productLocations.TryGetValue(productId, out string location))
            {
                // If the product is found, display the location
                Console.WriteLine($"The product is located at {location}.");
            }

            else
            {
                // If the product is not found, display a message
                Console.WriteLine("Product not found!");
            }
        }
    }
}