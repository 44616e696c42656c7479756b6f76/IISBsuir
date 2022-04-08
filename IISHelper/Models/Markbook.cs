using Newtonsoft.Json;
using System.Collections.Generic;

namespace IISHelper.Models
{
    public partial class Markbook
    {
        [JsonProperty("number")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Number { get; set; }

        [JsonProperty("averageMark")]
        public double AverageMark { get; set; }

        [JsonProperty("markPages")]
        public Dictionary<string, MarkPage> MarkPages { get; set; }
    }

    public partial class MarkPage
    {
        [JsonProperty("averageMark")]
        public double AverageMark { get; set; }

        [JsonProperty("marks")]
        public MarkElement[] Marks { get; set; }
    }

    public partial class MarkElement
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("formOfControl")]
        public string FormOfControl { get; set; }

        [JsonProperty("fullSubject")]
        public string FullSubject { get; set; }

        [JsonProperty("hours")]
        public string Hours { get; set; }

        [JsonProperty("mark")]
        public string Mark { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("teacher")]
        public string Teacher { get; set; }

        [JsonProperty("commonMark")]
        public double? CommonMark { get; set; }

        [JsonProperty("commonRetakes")]
        public double? CommonRetakes { get; set; }

        [JsonProperty("retakesCount")]
        public long RetakesCount { get; set; }

        [JsonProperty("idSubject")]
        public long IdSubject { get; set; }

        [JsonProperty("idFormOfControl")]
        public long IdFormOfControl { get; set; }

        [JsonProperty("canStudyInParallel")]
        public bool? CanStudyInParallel { get; set; }

        [JsonProperty("applicationHasAlreadyBeenSentForParallel")]
        public bool? ApplicationHasAlreadyBeenSentForParallel { get; set; }

        [JsonProperty("canLiquidationAcademicDifferences")]
        public object CanLiquidationAcademicDifferences { get; set; }

        [JsonProperty("applicationHasAlreadyBeenSentForAcademicDifferences")]
        public object ApplicationHasAlreadyBeenSentForAcademicDifferences { get; set; }

        [JsonProperty("lmsEducationTerms")]
        public LmsEducationTerm[] LmsEducationTerms { get; set; }
    }

    public partial class LmsEducationTerm
    {
        [JsonProperty("idLmsEducationTerm")]
        public long IdLmsEducationTerm { get; set; }

        [JsonProperty("subjectNameByApi")]
        public string SubjectNameByApi { get; set; }

        [JsonProperty("coincidedForeignLanguage")]
        public object CoincidedForeignLanguage { get; set; }
    }   
}
