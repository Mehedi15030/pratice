using System.ComponentModel.DataAnnotations;

namespace class6_pratice.Models
{
    public class Employe
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string emplyeeName { get; set; }
        [Required]
        [StringLength(100)]
        public string designation { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime birthdate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime joindate { get; set; }
        [EmailAddress]
        public string? email { get; set; }
        
        public long? phone { get; set; }
        [Url]
        public string website { get; set; }
        public double salary { get; set; }
        [Display(Name ="Is regular emplyee ?")]
        public bool isemplyee {  get; set; }

    }
}
