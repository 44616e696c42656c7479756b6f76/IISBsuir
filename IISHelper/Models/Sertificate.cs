using Newtonsoft.Json;

namespace IISHelper.Models
{
    public class Sertificate
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("provisionPlace")]
        public string ProvisionPlace { get; set; }

        [JsonProperty("dateOrder")]
        public string DateOrder { get; set; }

        [JsonProperty("certificateType")]
        public string CertificateType { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("rejectionReason")]
        public string RejectionReason { get; set; }
    }   
}
