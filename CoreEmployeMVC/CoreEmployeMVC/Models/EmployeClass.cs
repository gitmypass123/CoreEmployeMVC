using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEmployeMVC.Models
{
    public class EmployeClass
    {

        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = ("number must be 10 "))]
        public string EmployeNiC { get; set; }



        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]


        public DateTime Date { get; set; }
        public EmployeClass()
        {
            Date = DateTime.Now;
        }
    }
}
