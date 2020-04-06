using System.ComponentModel.DataAnnotations;

namespace Covid19Client.Models.DTO
{
    public class Environment
    {
        public Environment()
        {

        }
        [Required]
        public Housing Housing { get; set; }
        [Required]
        public string Transportation { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        [Range(1,5)]
        public int SocialDistance { get; set; }
    }
}
