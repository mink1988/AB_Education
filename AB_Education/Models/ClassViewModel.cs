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
        public SchoolClass schoolClasses { get; set; }
        public IEnumerable<ApplicationUser> Teachers { get; set; }
        public IEnumerable<SchoolClassStudent> Students { get; set; }
    }
}
