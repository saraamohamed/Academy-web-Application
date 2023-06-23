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
    public class TraineeHasCourse
    {
        [Key, Column(Order = 0)]
        public int TraineeNational_ID { get; set; }

        [Key, Column(Order = 1)]
        public int Course_ID { get; set; }

        public virtual Trainee Trainee { get; set; }
        public virtual Course Course { get; set; }


    }
}
