using System;
using System.Collections.Generic;

namespace Entities.Data.Models
{
    public partial class Person
    {
        public int? Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public DateTime? Bdate { get; set; }
    }
}
