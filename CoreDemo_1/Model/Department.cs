using Model.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class Department : IEntityBase
    {
        public Department()
        {
            Employees = new List<Employee>();
        }

        [Key, Column(Order = 0)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Department name is required.")]
        [StringLength(120)]
        [Column("name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Department description is required.")]
        [Column("description")]
        public string Description { get; set; }
        public RecordStatus RecordStatus { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
