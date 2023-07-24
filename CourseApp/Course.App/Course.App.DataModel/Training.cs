using Course.App.DataModel.Base;

namespace Course.App.DataModel
{

    public class Training:DomainEntity
    {
        public string TCode { get; set; }       
        public string Name { get; set; }
        public string Course { get; set; }        
        public string Month { get; set; }
        public string Status { get; set; }


    }
}
