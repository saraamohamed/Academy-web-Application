using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AcademyFP.Models
{
    public class TraineeFinancialTranscations
    {
        [Key]
        public int Transaction_id{ get; set; }
        public DateTime TransactionDateTime { get; set; }

        public bool ReceivedMoneyAmount { get; set; }

        [MaxLength(255)]
        public string?  Notes  { get; set; }

        //relational mapping 
        [ForeignKey("Course")]
        public int Course_ID { get; set; }
        public virtual Course Course { get; set; }
        
        [ForeignKey("Trainee")]
        public int TraineeNational_id { get; set; }
        public virtual Trainee Trainee { get; set; }

    }
}
