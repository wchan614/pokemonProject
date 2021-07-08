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


namespace pokemonProject.Pages
{
    public class IndexModel : PageModel
    {

        public List<string> pokemonNames = new List<string>();
        public void OnGet()
        {
            loadPokemon();
            Console.WriteLine("Done");
        }

        public void loadPokemon() {
            StreamReader file = new StreamReader(@".\wwwroot\lib\Pokemons.txt");
            string name;
            while ((name = file.ReadLine()) != null) {
                pokemonNames.Add(name);
            }
        }

        public void OnPostGetInfo(string id) {
            Console.WriteLine("Index post info ran.");
            Response.Redirect("./Pokemon?id=" + id);
        }

        public string fixStringPokemon(string name) {
            switch (name) {
                case "farfetch'd":
                    return "farfetchd";

                case "mr. mime":
                    return "mr-mime";

                case "mime jr.":
                    return "mime-jr";
                
                case "flabébé":
                    return "flabebe";

                case "type: null":
                    return "type-null";

                case "tapu koko":
                    return "tapu-koko";
                
                case "tapu lele":
                    return "tapu-lele";
                
                case "tapu bulu":
                    return "tapu-bulu";

                case "tapu fini":
                    return "tapu-fini";

                case "sirfetch'd":
                    return "sirfetchd";
                
                case "mr. rime":
                    return "mr-rime";

                default:
                    return name;
            }
        }
    }
}
