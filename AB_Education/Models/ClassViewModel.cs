using AB_Education.Data;
using AB_Education.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AB_Education.Models
{
    public class ClassViewModel
    {
       public Guid Id { get; set; }
       public string ClassName { get; set; }
       public string TeacherName { get; set; }
    }
}
