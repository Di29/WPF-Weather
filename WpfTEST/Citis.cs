﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var welcome = Welcome.FromJson(jsonString);
using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace QuickType
{
    

    public partial class Welcome
    {
        [JsonProperty("predictions")]
        public Prediction[] Predictions { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public partial class Prediction
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("matched_substrings")]
        public MatchedSubstring[] MatchedSubstrings { get; set; }

        [JsonProperty("place_id")]
        public string PlaceId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("structured_formatting")]
        public StructuredFormatting StructuredFormatting { get; set; }

        [JsonProperty("terms")]
        public Term[] Terms { get; set; }

        [JsonProperty("types")]
        public TypeElement[] Types { get; set; }
    }

    public partial class MatchedSubstring
    {
        [JsonProperty("length")]
        public long Length { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }
    }

    public partial class StructuredFormatting
    {
        [JsonProperty("main_text")]
        public string MainText { get; set; }

        [JsonProperty("main_text_matched_substrings")]
        public MatchedSubstring[] MainTextMatchedSubstrings { get; set; }

        [JsonProperty("secondary_text")]
        public string SecondaryText { get; set; }
    }

    public partial class Term
    {
        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum TypeElement { Geocode, Locality, Political };

    public partial class Welcome
    {
        public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                TypeElementConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class TypeElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeElement) || t == typeof(TypeElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "geocode":
                    return TypeElement.Geocode;
                case "locality":
                    return TypeElement.Locality;
                case "political":
                    return TypeElement.Political;
            }
            return 0;
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeElement)untypedValue;
            switch (value)
            {
                case TypeElement.Geocode:
                    serializer.Serialize(writer, "geocode");
                    return;
                case TypeElement.Locality:
                    serializer.Serialize(writer, "locality");
                    return;
                case TypeElement.Political:
                    serializer.Serialize(writer, "political");
                    return;
            }
            
        }

        public static readonly TypeElementConverter Singleton = new TypeElementConverter();
    }
}
