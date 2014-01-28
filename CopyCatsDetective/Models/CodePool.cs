﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CopyCatsDetective.Models
{
    public class CodePool
    {
        public int Id { get; set; }
        [Required]
        public string Language { get; set; }

        public virtual Account Admin { get; set; }
        public virtual ICollection<Account> Members { get; set; }
    }
}