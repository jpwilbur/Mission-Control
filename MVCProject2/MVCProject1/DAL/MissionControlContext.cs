using MVCProject1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCProject1.DAL
{
    public class MissionControlContext : DbContext
    {
        public MissionControlContext() : base ("MissionControlContext")
        { }
        
        public DbSet<MissionModel> Mission {get; set;}
        public DbSet<UserModels> User { get; set; }
        public DbSet<MissionQuestionModels> MissionQuestion { get; set; }
    }
}