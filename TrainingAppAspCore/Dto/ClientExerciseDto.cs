using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingAppAspCore.Dto
{
    public class ClientExerciseDto
    {
        public int ClientExerciseId { get; set; }
        public int ClientWorkoutId { get; set; }
        public int ExerciseId { get; set; }
        public virtual ExerciseDto Exercise { get; set; }
        public bool IsActive { get; set; }
    }
}
