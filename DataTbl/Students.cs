﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.DataTbl
    {
    public class Students:Common
        {
        
        public int RollNumber { get; set; }
        public string FullName { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public int Session { get; set; }
        public int DepartmentId { get; set; }
        public string Email { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string Password { get; set; }
        //public string DepartmentName { get; set; }
        //public Department Department { get; set; }
        }
    }
