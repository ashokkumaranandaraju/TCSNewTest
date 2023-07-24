using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.App.DataModel.Dto
{
    public class SubscriptionDto
    {
        public int? id { get; set; }
        public string? SubsCode { get; set; }
        public string? TrainingCode { get; set; }
        public string? Month { get; set; }
        public string? Status { get; set; }
        public string ?Userid { get; set; }
        public CourseDto? CourseInfo { get; set; }
        public TrainingDto? TrainingInfo { get; set; } 
        public UsersDto? UserInfo { get; set; }       

    }
    
}
