using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingAppAspCore.Dto
{
    public class AddClientWorkoutDto
    {
        public int ClientId { get; set; }

        public int WorkoutPlanId { get; set; }

        public int Frequency { get; set; }
    }
}
