using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_12_12day19.Modeels
{
    internal class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int projID{ get; set; }
        public string projName { get; set; }
        public string projDescription { get; set; }
        public string Owner { get; set; }
        public List<EmployeeInformation> EmployeeInformations{ get; set;}
    }
}
