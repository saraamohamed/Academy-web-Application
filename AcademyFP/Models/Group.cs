using System.ComponentModel.DataAnnotations;

namespace AcademyFP.Models
{
    public class Group
    {
        [Key]
        public int Group_ID { set;get;}
    
        public bool DeletionStatus { set; get; } = false;
      

        //Relational Mapping

        public virtual ICollection<User> Users { set; get; }



    }
}
