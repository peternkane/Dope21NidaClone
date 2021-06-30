using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEEK8APP.Models
{
    public class RoleManager
    {
        [Key]
        public long Id { get; set; }

        public string RoleName { get; set; }
    }
}
