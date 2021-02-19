using AB_Education.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace AB_Education.Entities
{
    public partial class SchoolClass
    {
        public SchoolClass()
        {
            SchoolClassCourses = new HashSet<SchoolClassCourse>();
            SchoolClassStudents = new HashSet<SchoolClassStudent>();
        }

        public Guid Id { get; set; }
        public string ClassName { get; set; }

        [DisplayName("Teacher")]
        public string TeacherId { get; set; }

        
        
        
        public virtual ApplicationUser Teacher { get; set; }
        public virtual ICollection<SchoolClassCourse> SchoolClassCourses { get; set; }
        public virtual ICollection<SchoolClassStudent> SchoolClassStudents { get; set; }
    }
}
