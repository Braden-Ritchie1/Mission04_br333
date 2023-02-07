using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_br333.models
{
    public class GradeCalculatorModel
    {
        //This class holds the input validation, getters and setters, and the models for each of the inputs in the grade calculator
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100 for Assignments.")]
        public double Assignments { get; set; }
        
        [Range (0, 100, ErrorMessage ="Please enter a number between 0 and 100 for Group Projects.")]
        public double Group { get; set; }

        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100 for Quizzes.")]
        public double Quizzes { get; set; }

        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100 for the Midterm Exam.")]
        public double Midterm { get; set; }

        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100 for the Final Exam.")]
        public double Final { get; set; }

        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100 for INTEX.")]
        public double INTEX { get; set; }


    }
}
