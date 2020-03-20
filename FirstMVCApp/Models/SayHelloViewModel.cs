using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Models
{
    public class SayHelloViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}
