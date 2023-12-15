using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_12_12day19.Modeels
{
    internal class DepartmentEmp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepId { get; set; }
        [StringLength(50, MinimumLength = 15)]
        public string DepName { get; set; }
        [Range(1, 5)]
        public int Floor { get; set; }
        public List<EmployeeInformation> EmployeeInformations { get; set; }

    }
}
