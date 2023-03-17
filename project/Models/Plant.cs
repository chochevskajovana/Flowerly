using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace project.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Picture URL")]
        public string PictureURL { get; set; }

        [Display(Name="Short description")]
        public string ShortDescription { get; set; }

        [Display(Name = "Long description")]
        public string LongDescription { get; set; }
        public bool Available { get; set; }
        public int Price { get; set; }
        [Display(Name = "In stock")]
        public int NumInStock { get; set; }
    }
}