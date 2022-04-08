using Newtonsoft.Json;

namespace IISHelper.Models
{
    public class Group
    {
        [JsonProperty("numberOfGroup")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long NumberOfGroup { get; set; }

        [JsonProperty("groupInfoStudentDto")]   
        public GroupInfoStudent[] GroupInfoStudents { get; set; }
    }   

    public class GroupInfoStudent
    {
        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("fio")]
        public string Fio { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
