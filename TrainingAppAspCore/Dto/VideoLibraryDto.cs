using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingAppAspCore.Dto
{
    public class VideoLibraryDto
    {
        public int VideoLibraryId { get; set; }
        public string VideoUrl { get; set; }
        public string AltTag { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
