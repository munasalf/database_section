using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_12_12day19.Modeels
{
    internal class EmployeeInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int EmployeeID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Adress { get; set; }
        [Range(18,50)]
        public int Age { get; set; }
        [DataType(DataType.Currency)]
        public decimal Salary {  get; set; }
        //[ForeignKey("Projects")]
        //public int projID { get; set; }
        [ForeignKey("departmentEmp")]
        public int? DepId {  get; set; }
        public DepartmentEmp? departmentEmp { get; set; }
        //public Project Projects { get; set; }
        public List<Project> projects { get; set; }
    }
}
