using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace obajans.Models
{
    public class datacontext : DbContext
    {
        public DbSet<haber> haberler { get; set; }
        public datacontext()
        {
            Database.SetInitializer(new Veritabaniolusturucu());
        }
    }
    public class Veritabaniolusturucu : CreateDatabaseIfNotExists<datacontext>
    {
        protected override void Seed(datacontext context)
        {
            haber habernesne = new haber();
            habernesne.yayıntarihi = DateTime.Now.Date;
            habernesne.baslik = "Deneme Baslik";
            habernesne.konu = "Deneme Konu";
            habernesne.icerik = "deneme icerik";
            habernesne.resimuri = "https://www.thesun.co.uk/wp-content/uploads/2018/06/NINTCHDBPICT000415544999.jpg?strip=all&w=960";
            habernesne.aciklama = "Deneme aciklama";
            habernesne.kaynak = "The sun news";
            habernesne.originnew = "https://www.thesun.co.uk/news/6611695/who-muharrem-ince-turkey-challenge-recep-erdogan-2018-election/";

            context.haberler.Add(habernesne);
            context.SaveChanges();
        }

    }
}