using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademyFP.Models
{
    public class User
    {
        [Key]
        [MaxLength(100)]
        public string Username { get; set; }

        [PasswordPropertyText]
        public int Password { get; set; }

        [MaxLength(100)]
        public string FullName { get; set; }
        
        [EmailAddress]
        [MaxLength(255)]
        public string Email { get; set; }

        public int PhoneNumber { get; set; }
        public bool ActivityStatus { get; set; } 
        public bool DeletionStatus { get; set; } = false;

        [ForeignKey("Group")]
        public int Group_ID { get; set; }

        [ForeignKey("Language")]
        public int Language_ID { get; set; }



        [ForeignKey("Branch_ID")]
        public int Branch_ID { get; set; }

        //Relational Mapping

        public virtual Group Group { get; set; }
        public virtual Language Language { get; set; }
        public virtual Branch Branch { get; set; }
        public bool IsSupervisor { get; set; }


    }
}
