using Course.App.DataModel.Base;

namespace Course.App.DataModel
{

    public class Course:DomainEntity
    {
       
        public string CCode { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

    }
}
