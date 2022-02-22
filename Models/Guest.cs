using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kutse.Models
{
    public class Guest
    {
        [Required(ErrorMessage = "Sissesta nimi")]
        public string name { get; set; }
        [Required(ErrorMessage = "Sissesta email")]
        [RegularExpression(@"\.+\@.+\..+", ErrorMessage = "Vali sisestatud email")]
        public string email { get; set; }
        [Required(ErrorMessage = "Sissesta telefoni number")]
        [RegularExpression(@"\+372",ErrorMessage ="Numbril alguses peal olema +372")]
        public string phone { get; set; }
        [Required(ErrorMessage = "Sissesta oma valik")]
        public bool? willattend { get; set; }

    }
}