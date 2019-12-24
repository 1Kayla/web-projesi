using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GirOr.Data.Entity
{
    public class TestClass
    {
        [Key]
        public int Id { get; set; }

        public string isim { get; set; }

        public string soyisim { get; set; }
        public string girisimAdi { get; set; }
        public int girisimYil { get; set; }

        [ForeignKey("AspNetUser")]
        public string fkUser { get; set; }
        public virtual IdentityUser AspNetUser { get;set;}
    }
}
