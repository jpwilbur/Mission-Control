using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCProject1.Models
{
    [Table("Mission")]
    public class MissionModel
    {
        [Key]
        [Required]
        public int missionID { get; set; }
        [Required]
        [DisplayName("Mission Name")]
        public String missionName { get; set; }
        [Required]
        [DisplayName("Mission President")]
        public String missionPresidentName { get; set; }
        [Required]
        [DisplayName("Mission Language")]
        public String missionLanguage { get; set; }
        [Required]
        [DisplayName("Mission Climate")]
        public String missionClimate { get; set; }
        [Required]
        [DisplayName("Mission Dominate Religion")]
        public String missionDomReligion { get; set; }
        [Required]
        [DisplayName("Mission President Pic Link")]
        public String missionPresidentPicLink { get; set; }
        [Required]
        [DisplayName("Mission Flag Link")]
        public String missionFlagLink { get; set; }
        [Required]
        [DisplayName("Mission Address")]
        public String missionAddress { get; set; }
        [Required]
        [DisplayName("Mission City")]
        public String missionCity { get; set; }
        [Required]
        [DisplayName("Mission State")]
        public String missionState { get; set; }
        [Required]
        [DisplayName("Mission Country")]
        public String missionCountry { get; set; }
        [Required]
        [DisplayName("Mission Zip")]
        public String missionZip { get; set; }


        public virtual ICollection<MissionQuestionModels> MissionQuestion { get; set; }
    }
}