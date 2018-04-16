using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace codefirst.Models.Places
{
    public class Province
    {
        [Key]
        [Display(Name = "Province Code")]
        public string provinceCode { get; set; }

        [Display(Name = "Province")]
        public string provinceName { get; set; }

        public List<City> cities { get; set; }

    }
}