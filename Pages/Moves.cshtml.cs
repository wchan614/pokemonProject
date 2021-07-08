using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.IO;
using pokemonProject.Models;
using pokemonProject.API;

namespace pokemonProject.Pages {
    public class MovesModel : PageModel {
        public Moves move{get; set;}

        public async Task OnGet(string move) {
            Console.WriteLine("OnGet in Moves");
            await Fetch.SearchMove("https://pokeapi.co/api/v2/move/"+move, this);
        }

        public Boolean isValidPokemon(string pkmn) {
            pkmn = char.ToUpper(pkmn.First()) + pkmn.Substring(1).ToLower();
            StreamReader file = new StreamReader(@".\wwwroot\lib\Pokemons.txt");
            string contents = file.ReadToEnd();
            if (contents.Contains(pkmn)) {
                return true;
            }
            return false;
        }
    }
}
