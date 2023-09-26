using System;
using System.Collections.Generic;

namespace p01.AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string>();
            Phrase(phrases);
            List<string> events = new List<string>();
            Events(events);
            List<string> authors = new List<string>();
            Authors(authors);
            List<string> cities = new List<string>();
            Cities(cities);
            Random random = new Random();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++) 
            {
                int indexPhrases = random.Next(0, phrases.Count);
                int indexEvents = random.Next(0, events.Count);
                int indexAuthors = random.Next(0, authors.Count);
                int indexCities = random.Next(0, cities.Count);
                Console.WriteLine($"{phrases[indexPhrases]} {events[indexEvents]} {authors[indexAuthors]} - {cities[indexCities]}");

            }
        }
        static List<string> Phrase(List<string> phrases) 
        {
            phrases.Add("Excellent product.");
            phrases.Add("Such a great product.");
            phrases.Add("I always use that product.");
            phrases.Add("Best product of its category.");
            phrases.Add("Exceptional product.");
            phrases.Add("I can't live without this product.");
            return phrases;
        }
        static List<string> Events (List<string> events) 
        {
            events.Add("Now I feel good.");
            events.Add("I have succeeded with this product.");
            events.Add("Makes miracles. I am happy of the results!");
            events.Add("I cannot believe but now I feel awesome.");
            events.Add("Try it yourself, I am very satisfied.");
            events.Add("I feel great!");
            return events;
        }
        static List<string> Authors (List<string> authors) 
        {
            authors.Add("Diana");
            authors.Add("Petya");
            authors.Add("Stella");
            authors.Add("Elena");
            authors.Add("Katya");
            authors.Add("Iva");
            authors.Add("Annie");
            authors.Add("Eva");
            return authors;
        }
        static List<string> Cities (List<string> cities) 
        {
            cities.Add("Burgas");
            cities.Add("Sofia");
            cities.Add("Plovdiv");
            cities.Add("Varna");
            cities.Add("Ruse");
            return cities;
        }
    }
}
