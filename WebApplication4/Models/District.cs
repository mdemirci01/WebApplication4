﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class District
    {
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "İlçe")]
        public string Name { get; set; }
        [Display(Name = "Şehir")]
        public Guid? CityId { get; set; }
        [ForeignKey("CityId")]
        [Display(Name = "Şehir")]
        public virtual City City { get; set; }
    }
}