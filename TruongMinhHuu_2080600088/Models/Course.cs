using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TruongMinhHuu_2080600088.Models
{
    public class Course
    {
        public int Id { set; get; }
        public ApplicationUser Lecture { get; set; }
        [Required]
        public string LectureId { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { set; get; }
        public DateTime DateTime { set; get; }
        public Category Category { set; get; }
        [Required]

        public byte CategoryId { get; set; }
    }

    
}