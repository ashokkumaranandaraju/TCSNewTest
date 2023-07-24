using Course.App.DataModel.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Course.App.DataModel
{
 
    public class Subscription:DomainEntity
    {    
        public string SubsCode { get; set; }                
        public string TrainingCode { get; set; }
        public string Month { get; set; }
        public string Status { get; set; }
        public string Userid { get; set; }

    }
}
