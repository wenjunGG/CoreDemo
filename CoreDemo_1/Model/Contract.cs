﻿using Model.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Contract : IEntityBase
    {
        [Key, Column(Order = 0)]

        public int Id { get; set; }

        [Required(ErrorMessage = "Contract name is required.")]
        [StringLength(120)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

       [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Required]
        public int Amount { get; set; }


        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }


        public Employee Employee { get; set; }

        public RecordStatus RecordStatus { get; set; }

    }
}