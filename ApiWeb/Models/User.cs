using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiWeb.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string DisplayName { get; set; }
    }
}