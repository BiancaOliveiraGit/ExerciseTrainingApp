using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingAppAspCore.Dto
{
    public class ExerciseDto
    {
        public int ExerciseId { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int VideoLibraryId { get; set; }
        public bool DoNotUse { get; set; }
        public VideoLibraryDto VideoLibrary { get; set; }

    }
}
