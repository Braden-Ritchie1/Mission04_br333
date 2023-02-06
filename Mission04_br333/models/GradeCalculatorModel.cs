using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_br333.models
{
    public class GradeCalculatorModel
    {
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100.")]
        public double Assignments { get; set; }
        
        [Range (0, 100, ErrorMessage ="Please enter a number between 0 and 100.")]
        public double Group { get; set; }

        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100.")]
        public double Quizzes { get; set; }

        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100.")]
        public double Midterm { get; set; }

        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100.")]
        public double Final { get; set; }

        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100.")]
        public double INTEX { get; set; }


    }
}
