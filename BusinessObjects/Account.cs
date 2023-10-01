using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    [Table("Account",Schema ="dto")]
    internal class Account
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public BigInteger Id {  get; set; }
        [Required]
        [StringLength(50)]
        public String username;
        [Required]
        public String password;
    }
}
