namespace TrainingAppAspCore.Dto
{
    public class WorkoutExerciseDto
    {     
        public int WorkoutPlanId { get; set; }
        public int ExerciseId { get; set; }
        public ExerciseDto Exercise { get; set; }
        public bool DoNotUse { get; set; }
    }
}
