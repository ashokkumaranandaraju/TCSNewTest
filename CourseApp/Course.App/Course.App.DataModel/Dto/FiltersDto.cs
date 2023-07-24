using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.App.DataModel.Dto
{
    public class FiltersDto
    {
        public TrainingDto? Training { get; set; }
        public CourseDto? Course { get; set; }
        public string? Month { get; set; }
        public UsersDto? user { get; set; }
    }
}
