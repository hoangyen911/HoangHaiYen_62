using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HoangHaiYen_62.Models
{
    [Table("nhacungcaps")]
    public class NhaCungCap
    {
        [Key]
        public int manhacungcap { get; set; }
        public string tennhacungcap { get; set; } 
    }
}