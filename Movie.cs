using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imdb
{

    public class Film
    {
        public string Name { get; set; }//create the Name property
        public double ImdbPoint { get; set; } //create the Imdb property

        public List<Film> films = new List<Film>();// Create the list instance for the film

        public void FilmList()// we created the filmlist method for the all process
        {
            while (true) //we input the while loop
            {
                Console.WriteLine("Please Enter The Film Name (or type 'e' to finish):");// we want to the user film name or send to the our 'e' for the exit
                string name = Console.ReadLine();

                if (name.Equals("e", StringComparison.OrdinalIgnoreCase))// if user push the 'e' we ended loop and give the message
                {
                    break;
                }

                Console.WriteLine("Please Enter the Imdb Point:");// if user input the film name we wnat to the Imdb point for the film
                string imdbInput = Console.ReadLine();

                if (!double.TryParse(imdbInput, out double imdbPoint))// we handle it imdb number if wrong type we stoped user and we wait correct value
                {
                    Console.WriteLine("Invalid IMDb Point. Please enter a valid number.");
                    continue;
                }

                // we created the film instance 
                Film film = new Film
                {
                    Name = name,//we assign the variable
                    ImdbPoint = imdbPoint
                };
                films.Add(film);// we added film list
            }
            Console.WriteLine("Film List:");
            foreach (var film in films)
            {
                Console.WriteLine($"Name: {film.Name} IMDb Point: {film.ImdbPoint}");// we return the all film list question 1
            }

            Console.WriteLine("Film List Imdb point range of 4-9:");
            foreach (var film in films)
            {

                if (film.ImdbPoint > 4 && film.ImdbPoint < 9)
                {
                    Console.WriteLine($"Name: {film.Name} IMDb Point: {film.ImdbPoint}");// we return the film list if imdb point greater than 4 and less than 9

                }

            }
            Console.WriteLine("Film List Imdb Start  with A");

            foreach (var film in films)
                {

                    if (film.Name.ToUpper()[0] == 'A')// we handle it upper method if user input a
                    {
                        Console.WriteLine($"Name: {film.Name} IMDb Point: {film.ImdbPoint}");// we return the film list if film start 'A' text

                    }
                }
            }
        }
    }

