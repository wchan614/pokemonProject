
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace pokemonProject.Models {

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class UseAfter
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Normal
    {
        [JsonPropertyName("use_after")]
        public List<UseAfter> UseAfter { get; set; }

        [JsonPropertyName("use_before")]
        public object UseBefore { get; set; }
    }

    public class Super
    {
        [JsonPropertyName("use_after")]
        public object UseAfter { get; set; }

        [JsonPropertyName("use_before")]
        public object UseBefore { get; set; }
    }

    public class ContestCombos
    {
        [JsonPropertyName("normal")]
        public Normal Normal { get; set; }

        [JsonPropertyName("super")]
        public Super Super { get; set; }
    }

    public class ContestEffect
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class ContestType
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class DamageClass
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class MoveLanguage
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class EffectEntry
    {
        [JsonPropertyName("effect")]
        public string Effect { get; set; }

        [JsonPropertyName("language")]
        public MoveLanguage Language { get; set; }

        [JsonPropertyName("short_effect")]
        public string ShortEffect { get; set; }
    }

    public class MoveVersionGroup
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class MoveFlavorTextEntry
    {
        [JsonPropertyName("flavor_text")]
        public string FlavorText { get; set; }

        [JsonPropertyName("language")]
        public Language Language { get; set; }

        [JsonPropertyName("version_group")]
        public MoveVersionGroup VersionGroup { get; set; }
    }

    public class MoveGeneration
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class LearnedByPokemon
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Ailment
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Category
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Meta
    {
        [JsonPropertyName("ailment")]
        public Ailment Ailment { get; set; }

        [JsonPropertyName("ailment_chance")]
        public int? AilmentChance { get; set; }

        [JsonPropertyName("category")]
        public Category Category { get; set; }

        [JsonPropertyName("crit_rate")]
        public int? CritRate { get; set; }

        [JsonPropertyName("drain")]
        public int? Drain { get; set; }

        [JsonPropertyName("flinch_chance")]
        public int? FlinchChance { get; set; }

        [JsonPropertyName("healing")]
        public int? Healing { get; set; }

        [JsonPropertyName("max_hits")]
        public object MaxHits { get; set; }

        [JsonPropertyName("max_turns")]
        public object MaxTurns { get; set; }

        [JsonPropertyName("min_hits")]
        public object MinHits { get; set; }

        [JsonPropertyName("min_turns")]
        public object MinTurns { get; set; }

        [JsonPropertyName("stat_chance")]
        public int? StatChance { get; set; }
    }

    public class MoveName
    {
        [JsonPropertyName("language")]
        public MoveLanguage Language { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class PastValue
    {
        [JsonPropertyName("accuracy")]
        public int? Accuracy { get; set; }

        [JsonPropertyName("effect_chance")]
        public object EffectChance { get; set; }

        [JsonPropertyName("effect_entries")]
        public List<object> EffectEntries { get; set; }

        [JsonPropertyName("power")]
        public int? Power { get; set; }

        [JsonPropertyName("pp")]
        public object Pp { get; set; }

        [JsonPropertyName("type")]
        public object Type { get; set; }

        [JsonPropertyName("version_group")]
        public MoveVersionGroup VersionGroup { get; set; }
    }

    public class SuperContestEffect
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Target
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class MoveType
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Moves
    {
        [JsonPropertyName("accuracy")]
        public int? Accuracy { get; set; }

        [JsonPropertyName("contest_combos")]
        public ContestCombos ContestCombos { get; set; }

        [JsonPropertyName("contest_effect")]
        public ContestEffect ContestEffect { get; set; }

        [JsonPropertyName("contest_type")]
        public ContestType ContestType { get; set; }

        [JsonPropertyName("damage_class")]
        public DamageClass DamageClass { get; set; }

        [JsonPropertyName("effect_chance")]
        public object EffectChance { get; set; }

        [JsonPropertyName("effect_changes")]
        public List<object> EffectChanges { get; set; }

        [JsonPropertyName("effect_entries")]
        public List<EffectEntry> EffectEntries { get; set; }

        [JsonPropertyName("flavor_text_entries")]
        public List<MoveFlavorTextEntry> FlavorTextEntries { get; set; }

        [JsonPropertyName("generation")]
        public MoveGeneration Generation { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("learned_by_pokemon")]
        public List<LearnedByPokemon> LearnedByPokemon { get; set; }

        [JsonPropertyName("machines")]
        public List<object> Machines { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }

        [JsonPropertyName("past_values")]
        public List<PastValue> PastValues { get; set; }

        [JsonPropertyName("power")]
        public int? Power { get; set; }

        [JsonPropertyName("pp")]
        public int? Pp { get; set; }

        [JsonPropertyName("priority")]
        public int? Priority { get; set; }

        [JsonPropertyName("stat_changes")]
        public List<object> StatChanges { get; set; }

        [JsonPropertyName("super_contest_effect")]
        public SuperContestEffect SuperContestEffect { get; set; }

        [JsonPropertyName("target")]
        public Target Target { get; set; }

        [JsonPropertyName("type")]
        public MoveType Type { get; set; }
    }
}
