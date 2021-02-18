using System;
using System.Collections.Generic;

#nullable disable

namespace AB_Education.Entities
{
    public partial class SchoolClassCourse
    {
        public Guid SchoolClassId { get; set; }
        public Guid SchoolCourseId { get; set; }

        
        public virtual SchoolClass SchoolClass { get; set; }
        public virtual SchoolCourse SchoolCourse { get; set; }
    }
}
