using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using obajans.Models;
namespace obajans.clas
{

    public class NewsFinder
{
        public haber getnew(int id1)
        {
            datacontext db = new datacontext();
                return (db.haberler.Where(p => p.id == id1).FirstOrDefault<haber>());
        }
}
}