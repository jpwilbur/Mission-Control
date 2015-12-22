using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCProject1.Models
{
    [Table("User")]
    public class UserModels
    {
        [Key]
        [Required]
        public int userID { get; set; }
        [Required]
        [EmailAddress]
        public String userEmail { get; set; }
        [Required]
        [StringLength(16, ErrorMessage = "Must be shorter than 16 characters.")]
        public String password { get; set; }
        [Required]
        public String userFirstName { get; set; }
        [Required]
        public String userLastName { get; set; }


        public virtual ICollection<MissionQuestionModels> MissionQuestion { get; set; }
    }
}