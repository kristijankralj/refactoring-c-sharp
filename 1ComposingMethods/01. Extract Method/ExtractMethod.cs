using System;
using System.Collections.Generic;
using System.Linq;

namespace ComposingMethods
{
    public class SearchSmartphones
    {
        List<string> smartphones = new List<string>()
            {
                "Samsung Galaxy S10", "Pixel 2", "Pixel 3", "Pixel 4", "iPhone XR", "iPhone 11", "iPhone 11 Pro", "iPhone 11 Pro Max" 
            };

        public void PerformSearch()
        {
            bool continueSearch = true;

            while (continueSearch)
            {
                Console.Write("Search for smartphone: ");
                string keyword = Console.ReadLine();

                var results = smartphones.Where(phone => phone.ToLower().Contains(keyword.ToLower()));

                if (results != null)
                {
                    Console.WriteLine("Here are the matched results.\n");

                    foreach (var result in results)
                    {
                        Console.WriteLine(result);
                    }
                }
                else
                {
                    Console.WriteLine("No results found.");
                }

                string continueSearchResponse;
                do
                {
                    Console.Write("\nMake another search (y/n)?: ");
                    continueSearchResponse = Console.ReadLine();

                    if (continueSearchResponse.ToLower() == "n")
                    {
                        continueSearch = false;
                        break;
                    }
                    if (continueSearchResponse.ToLower() != "y")
                    {
                        Console.WriteLine("Invalid response.");
                    }

                } while (continueSearchResponse.ToLower() != "n" && continueSearchResponse.ToLower() != "y");
            }

            Console.Write("Thanks for searching!");

        }
    }
}
