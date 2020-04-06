
using System;
using System.ComponentModel.DataAnnotations;

namespace Covid19Client.Models.DTO
{
    public class DailyAssessment
    {
        public DailyAssessment()
        {

        }
        [Required(AllowEmptyStrings =false)]
        public string DeviceId { get; set; }
        public DateTime RecordDate { get; set; }
        [Required()]
        public DateTime TransmitionDate { get; set; }
        [Range(0,110)]
        [Required()]
        public int Age { get; set; }
        [Required()]
        public Gender Gender { get; set; }
        [Required()]
        public Symptom Symptom { get; set; }
        [Required()]
        public Environment Environment { get; set; }
    }
}
