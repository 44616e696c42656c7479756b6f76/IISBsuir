using Newtonsoft.Json;

namespace IISHelper.Models
{
    public class Marksheet
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("subject")]
        public Subject Subject { get; set; }

        [JsonProperty("markSheetType")]
        public MarkSheetType MarkSheetType { get; set; }

        [JsonProperty("employee")]
        public Employee Employee { get; set; }

        [JsonProperty("absentDate")]
        public string AbsentDate { get; set; }

        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("hours")]
        public long? Hours { get; set; }

        [JsonProperty("reason")]
        public long Reason { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("rejectionReason")]
        public string RejectionReason { get; set; }

        [JsonProperty("requestValidationDoc")]
        public object RequestValidationDoc { get; set; }

        [JsonProperty("retakeCount")]
        public long? RetakeCount { get; set; }

        [JsonProperty("certificate")]
        public bool Certificate { get; set; }

        [JsonProperty("expireDate")]
        public object ExpireDate { get; set; }

        [JsonProperty("term")]
        public long Term { get; set; }

        [JsonProperty("price")]
        public object Price { get; set; }

        [JsonProperty("paymentFormMap")]
        public object PaymentFormMap { get; set; }
    }

    public partial class Employee
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("fio")]
        public string Fio { get; set; }

        [JsonProperty("academicDepartment")]
        public string AcademicDepartment { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }
    }

    public partial class MarkSheetType
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("fullName")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long FullName { get; set; }

        [JsonProperty("price")]
        public object Price { get; set; }

        [JsonProperty("coefficient")]
        public double Coefficient { get; set; }
    }

    public partial class Subject
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("abbrev")]
        public string Abbrev { get; set; }

        [JsonProperty("thId")]
        public long? ThId { get; set; }

        [JsonProperty("focsId")]
        public long? FocsId { get; set; }

        [JsonProperty("lessonTypeAbbrev")]
        public string LessonTypeAbbrev { get; set; }

        [JsonProperty("term")]
        public long Term { get; set; }
    }
}
