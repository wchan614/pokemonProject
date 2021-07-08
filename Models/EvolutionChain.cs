 
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace pokemonProject.Models
{
  public class EvoChainItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class KnownMoveType
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Location
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Trigger
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class EvolutionDetail
    {
        [JsonPropertyName("gender")]
        public object Gender { get; set; }

        [JsonPropertyName("held_item")]
        public object HeldItem { get; set; }

        [JsonPropertyName("item")]
        public EvoChainItem Item { get; set; }

        [JsonPropertyName("known_move")]
        public object KnownMove { get; set; }

        [JsonPropertyName("known_move_type")]
        public KnownMoveType KnownMoveType { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }

        [JsonPropertyName("min_affection")]
        public int? MinAffection { get; set; }

        [JsonPropertyName("min_beauty")]
        public object MinBeauty { get; set; }

        [JsonPropertyName("min_happiness")]
        public int? MinHappiness { get; set; }

        [JsonPropertyName("min_level")]
        public object MinLevel { get; set; }

        [JsonPropertyName("needs_overworld_rain")]
        public bool NeedsOverworldRain { get; set; }

        [JsonPropertyName("party_species")]
        public object PartySpecies { get; set; }

        [JsonPropertyName("party_type")]
        public object PartyType { get; set; }

        [JsonPropertyName("relative_physical_stats")]
        public object RelativePhysicalStats { get; set; }

        [JsonPropertyName("time_of_day")]
        public string TimeOfDay { get; set; }

        [JsonPropertyName("trade_species")]
        public object TradeSpecies { get; set; }

        [JsonPropertyName("trigger")]
        public Trigger Trigger { get; set; }

        [JsonPropertyName("turn_upside_down")]
        public bool TurnUpsideDown { get; set; }
    }

    public class EvoChainSpecies
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Chain
    {
        [JsonPropertyName("evolution_details")]
        public List<object> EvolutionDetails { get; set; }

        [JsonPropertyName("evolves_to")]
        public List<Chain> EvolvesTo { get; set; }

        [JsonPropertyName("is_baby")]
        public bool IsBaby { get; set; }

        [JsonPropertyName("species")]
        public EvoChainSpecies Species { get; set; }
    }

    public class EvoChain
    {
        [JsonPropertyName("baby_trigger_item")]
        public object BabyTriggerItem { get; set; }

        [JsonPropertyName("chain")]
        public Chain Chain { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}