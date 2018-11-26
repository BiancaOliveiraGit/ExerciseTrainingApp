
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingApi.Data
{
    public class WorkoutExercise
    {
        [Key]
        public int WorkoutExerciseId { get; set; }

        [ForeignKey("WorkoutPlan")]
        public int WorkoutPlanId { get; set; }

        [ForeignKey("Exercise")]
        public int ExerciseId { get; set; }

        [NotMapped]
        public IEnumerable<Exercise> Exercises { get; set; }
        public bool DoNotUse { get; set; }
    }
}
