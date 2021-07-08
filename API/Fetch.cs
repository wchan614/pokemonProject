using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System;
using pokemonProject.Models;
using pokemonProject.Pages;

namespace pokemonProject.API {

    public static class Fetch {
        private static HttpClient client = new HttpClient();

        public static  async Task SearchPokemon(string name, PokemonModel pkmnPage) {
            ClearHeader();
            HttpResponseMessage response = await client.GetAsync("https://pokeapi.co/api/v2/pokemon/" + name);

            if (response.IsSuccessStatusCode) {
                string rawData = await response.Content.ReadAsStringAsync();
                pkmnPage.pkmn = JsonSerializer.Deserialize<Pokemon>(rawData);
            }
            else {
                Console.WriteLine("Error has occured in Fetch.cs SearchPokemon(). Response code not 200 OK.");
                pkmnPage.pkmn = null;
            }
        }

        public static async Task SearchSpecies(string url, PokemonModel pkmnPage) {
            ClearHeader();
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode) {
                string rawData = await response.Content.ReadAsStringAsync();
                pkmnPage.species = JsonSerializer.Deserialize<PokemonSpecies>(rawData);
            }
            else {
                Console.WriteLine("Error has occured in Fetch.cs SearchSpecies(). Response code not 200 OK.");
                pkmnPage.species = null;
            }
        }

        public static async Task SearchEvoChain(string url, PokemonModel pkmnPage) {
            ClearHeader();
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode) {
                string rawData = await response.Content.ReadAsStringAsync();
                pkmnPage.chain = JsonSerializer.Deserialize<EvoChain>(rawData);
            }
            else {
                Console.WriteLine("Error has occured in Fetch.cs SearchEvoChain(). Response code not 200 OK.");
                pkmnPage.species = null;
            }
        }

        public static async Task SearchType(string url, PokemonModel pkmnPage) {
            ClearHeader();
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode) {
                string rawData = await response.Content.ReadAsStringAsync();
                pkmnPage.type = JsonSerializer.Deserialize<Types>(rawData);
            }
            else {
                Console.WriteLine("Error has occured in Fetch.cs SearchType(). Response code not 200 OK.");
                pkmnPage.type = null;
            }
        }

        public static async Task SearchMove(string url, MovesModel movesPage) {
            ClearHeader();
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode) {
                string rawData = await response.Content.ReadAsStringAsync();
                movesPage.move = JsonSerializer.Deserialize<Moves>(rawData);
            }
            else {
                Console.WriteLine("Error has occured in Fetch.cs SearchMove(). Response code not 200 OK.");
                movesPage.move = null;
            }
        }

        public static async Task SearchAbility(string url, AbilitiesModel abilityModel) {
            ClearHeader();
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode) {
                string rawData = await response.Content.ReadAsStringAsync();
                abilityModel.ability = JsonSerializer.Deserialize<Abilities>(rawData);
            }
            else {
                Console.WriteLine("Error has occured in Fetch.cs SearchMove(). Response code not 200 OK.");
                abilityModel.ability = null;
            }
        }

        public static void ClearHeader() {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applicationException/json"));
        }
    }
}