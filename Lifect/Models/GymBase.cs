using Lifect.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lifect.Models
{
    public class GymBase : DbContext
    {
        public DbSet<Training> Trainings { get; set; }

        public DbSet<Exercise> Exercise { get; set; }

        public DbSet<MuscleGroup> MuscleGroups { get; set; }

    }
}