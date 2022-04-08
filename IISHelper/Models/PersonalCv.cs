using Newtonsoft.Json;
using System;

namespace IISHelper.Models
{
    public class PersonalCv
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("photoUrl")]
        public Uri PhotoUrl { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("rating")]
        public long Rating { get; set; }

        [JsonProperty("showRating")]
        public bool ShowRating { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("searchJob")]
        public bool SearchJob { get; set; }

        [JsonProperty("faculty")]
        public string Faculty { get; set; }

        [JsonProperty("course")]
        public long Course { get; set; }

        [JsonProperty("officeEmail")]
        public string OfficeEmail { get; set; }

        [JsonProperty("officePassword")]
        public string OfficePassword { get; set; }

        [JsonProperty("speciality")]
        public string Speciality { get; set; }

        [JsonProperty("studentGroup")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long StudentGroup { get; set; }

        [JsonProperty("skills")]
        public Skill[] Skills { get; set; }

        [JsonProperty("references")]
        public object[] References { get; set; }
    }

    public partial class Skill
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }
    }
}