using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.App.DataModel.Dto
{
    public class TrainingDto
    {
        public int? Id { get; set; }
        public string? TCode { get; set; }
        public string? Name { get; set; }
        public string? Course { get; set; }
        public string? Month { get; set; }
        public string? Status { get; set; }

        public static TrainingDto FromEntity(Training trn)
        {
            return new TrainingDto
            {
                Id = trn.Id,
                TCode = trn.TCode,
                Name = trn.Name,
                Course = trn.Course,
                Month = trn.Month,
                Status = trn.Status
            };
        }
    }
}
