using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace obajans.Models
{
    public class haber
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string baslik { get; set; }
        public string konu { get; set; }
        public string resimuri { get; set; }
        public string icerik { get; set; }
        public DateTime yayıntarihi { get; set; }
        public string aciklama { get; set; }
        public string kaynak { get; set; }
        public string originnew { get; set; }
    }
}