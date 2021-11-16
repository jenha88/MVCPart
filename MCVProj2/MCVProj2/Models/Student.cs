using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCVProj2.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        [DisplayName("TA LastName")]
        public string LastName { get; set; }
        public int SoonerID { get; set; }
    }
}