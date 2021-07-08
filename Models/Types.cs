// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace pokemonProject.Models{

    public class DoubleDamageFrom
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class DoubleDamageTo
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class HalfDamageFrom
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class HalfDamageTo
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class NoDamageFrom
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class DamageRelations
    {
        [JsonPropertyName("double_damage_from")]
        public List<DoubleDamageFrom> DoubleDamageFrom { get; set; }

        [JsonPropertyName("double_damage_to")]
        public List<DoubleDamageTo> DoubleDamageTo { get; set; }

        [JsonPropertyName("half_damage_from")]
        public List<HalfDamageFrom> HalfDamageFrom { get; set; }

        [JsonPropertyName("half_damage_to")]
        public List<HalfDamageTo> HalfDamageTo { get; set; }

        [JsonPropertyName("no_damage_from")]
        public List<NoDamageFrom> NoDamageFrom { get; set; }

        [JsonPropertyName("no_damage_to")]
        public List<object> NoDamageTo { get; set; }
    }

    public class TypesGeneration
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class TypeGameIndice
    {
        [JsonPropertyName("game_index")]
        public int GameIndex { get; set; }

        [JsonPropertyName("generation")]
        public TypesGeneration Generation { get; set; }
    }

    public class MoveDamageClass
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class TypeMove
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class TypeLanguage
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class TypeName
    {
        [JsonPropertyName("language")]
        public TypeLanguage Language { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Pokemon2
    {
        [JsonPropertyName("name")]
        public string TypeName { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("pokemon")]
        public Pokemon Pokemon { get; set; }

        [JsonPropertyName("slot")]
        public int Slot { get; set; }
    }

    public class Types
    {
        [JsonPropertyName("damage_relations")]
        public DamageRelations DamageRelations { get; set; }

        [JsonPropertyName("game_indices")]
        public List<GameIndice> TypeGameIndices { get; set; }

        [JsonPropertyName("generation")]
        public TypesGeneration Generation { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("move_damage_class")]
        public MoveDamageClass MoveDamageClass { get; set; }

        [JsonPropertyName("moves")]
        public List<TypeMove> Moves { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("names")]
        public List<TypeName> Names { get; set; }

        [JsonPropertyName("pokemon")]
        public List<Pokemon> Pokemon { get; set; }
    }
}
