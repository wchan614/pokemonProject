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
    public class PokemonModel : PageModel {
        public Pokemon pkmn {get; set;}
        public PokemonSpecies species {get; set;}
        public EvoChain chain {get; set;}
        public Types type {get; set;}

        public async Task OnGet(string id) {
            // Get data and update our pokemon
            Console.WriteLine("Ran OnGet in Pokemon Page");
            await Fetch.SearchPokemon(id, this);
            if (pkmn != null) {
                await Fetch.SearchSpecies(pkmn.Species.Url, this);
                await Fetch.SearchEvoChain(species.EvolutionChain.Url, this);
            }
        }

        public async Task GetType(string url) {
            await Fetch.SearchType(url,this);
        }

        public void OnPostGetMoves(string move) {
/*             Response.Redirect("./Moves?move=" + move.ToLower().Replace(" ","-"));  */
            Console.WriteLine("OnPostMove Ran: " + move);
            Console.WriteLine("Done OnPostMove");
        }

    }
}