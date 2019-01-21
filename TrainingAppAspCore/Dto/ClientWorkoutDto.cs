using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingAppAspCore.Dto
{
    public class ClientWorkoutDto
    {
        public int ClientWorkoutId { get; set; }
        public int ClientId { get; set; }
        public int ClientExerciseId { get; set; }
        public IEnumerable<ClientExerciseDto> ClientExercises { get; set; }
        public int WorkoutPlanId { get; set; }
        public WorkoutPlanDto WorkoutPlan { get; set; }
        public int Frequency { get; set; }
    }
}
