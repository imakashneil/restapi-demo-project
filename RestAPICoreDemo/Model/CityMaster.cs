﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPICoreDemo.Model
{
    public class CityMaster
    {

        [Key]
        public int Id { get; set; }
        public string CityName { get; set; }
       
       
    }
}
