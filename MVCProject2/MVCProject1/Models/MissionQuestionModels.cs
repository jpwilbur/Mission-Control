using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCProject1.Models
{
    [Table("MissionQuestion")]
    public class MissionQuestionModels
    {
        [Key]
        [Required]
        public int missionQuestionID { get; set; }
        [Required]
        [DisplayName("Question")]
        public String question { get; set; }
        [Required]
        [DisplayName("Answer")]
        public String answer { get; set; }

        [Required]
        [ForeignKey("Mission")]
        public virtual int MissionID { get; set; }
        public virtual MissionModel Mission { get; set; }
        [Required]
        [ForeignKey("User")]
        public virtual int userID { get; set; }
        public virtual UserModels User { get; set; }
  
    }
}