using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API_Demo.Models
{
    public class SampleEmployee
    {
        public string Id { get; set; }
      //  [Column("First Name")]
        public string FirstName { get; set; }
      //  [Column("Last Name")]
        public string LastName { get; set; }
        public decimal Marks { get; set; }
    }
}