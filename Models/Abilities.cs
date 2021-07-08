// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace pokemonProject.Models {
    public class AbilityLanguage
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class AbilityEffectEntry
    {
        [JsonPropertyName("effect")]
        public string Effect { get; set; }

        [JsonPropertyName("language")]
        public AbilityLanguage Language { get; set; }

        [JsonPropertyName("short_effect")]
        public string ShortEffect { get; set; }
    }

    public class AbilityVersionGroup
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class EffectChanx
    {
        [JsonPropertyName("effect_entries")]
        public List<EffectEntry> EffectEntries { get; set; }

        [JsonPropertyName("version_group")]
        public AbilityVersionGroup VersionGroup { get; set; }
    }

    public class AbilityFlavorTextEntry
    {
        [JsonPropertyName("flavor_text")]
        public string FlavorText { get; set; }

        [JsonPropertyName("language")]
        public AbilityLanguage Language { get; set; }

        [JsonPropertyName("version_group")]
        public AbilityVersionGroup VersionGroup { get; set; }
    }

    public class AbilityGeneration
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class AbilityName
    {
        [JsonPropertyName("language")]
        public AbilityLanguage Language { get; set; }

        [JsonPropertyName("name")]
        public string Names { get; set; }
    }

    public class AbilityPokemon2
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("is_hidden")]
        public bool IsHidden { get; set; }

        [JsonPropertyName("pokemon")]
        public AbilityPokemon2 Pokemon { get; set; }

        [JsonPropertyName("slot")]
        public int Slot { get; set; }
    }

    public class Abilities
    {
        [JsonPropertyName("effect_changes")]
        public List<EffectChanx> EffectChanges { get; set; }

        [JsonPropertyName("effect_entries")]
        public List<AbilityEffectEntry> EffectEntries { get; set; }

        [JsonPropertyName("flavor_text_entries")]
        public List<AbilityFlavorTextEntry> FlavorTextEntries { get; set; }

        [JsonPropertyName("generation")]
        public AbilityGeneration Generation { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("is_main_series")]
        public bool IsMainSeries { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("names")]
        public List<AbilityName> Names { get; set; }

        [JsonPropertyName("pokemon")]
        public List<AbilityPokemon2> Pokemon { get; set; }
    }
}