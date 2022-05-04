using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DotnetBakery.Models
{
    public class Baker
    {
        // behind the scenes, EF knows id is primary key
        public int id { get; set; }

        // Makes this field NOT NULL
        [Required]

        public string name { get; set; }

        public int age { get; set; }


    }
}
