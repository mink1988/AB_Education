using AB_Education.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace AB_Education.Entities
{
    public partial class SchoolClassStudent
    {
        [DisplayName("Student")]
        public string StudentId { get; set; }
        public Guid SchoolClassId { get; set; }


        public virtual SchoolClass SchoolClass { get; set; }
    }
}
