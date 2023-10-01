using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace BusinessObjects
{
    [Table("Catoon", Schema = "dbo")]
    public class Cartoon
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public BigInteger Id { get; set; }
        [Required]
        [StringLength(50)]
        public String? CartoonName { get; set; }
        [Required]
        public DateTime LaunchDate {  get; set; }
        [Required]
        public ECartoonType CartoonType { get; set; }
        [Required]
        public String? ShortDesciption {  get; set; }
        [Required]
        public String? Producer { get; set; }
        [Required]
        public String? Duration { get; set; }

        [Required]
        public String?Actor { get; set; }
        [Required]
        public String? Director { get; set; }
        [Required]
        public String? Country { get; set; }
    }
}