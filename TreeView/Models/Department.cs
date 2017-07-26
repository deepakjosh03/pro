using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TreeView.Models
{
    public class Department
    {
        [Required]
        public int DepartmentID { get; set; }
        [Required]
        public string DepartmentName { get; set; }
    }
}