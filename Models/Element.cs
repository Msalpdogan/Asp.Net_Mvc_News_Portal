using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace obajans.Models
{
    public class Element
    {
        public string GetBeforeElement(HtmlString id)
        {
            
            try
            {
                int tempid = int.Parse(id.ToString());
                datacontext db = new datacontext();
                //   return (db.haberler.Where(p => p.id < Convert.ToInt16(id)).OrderByDescending(p => p.id).FirstOrDefault().id);
                return "./"+db.haberler.Where(p => p.id < tempid).OrderByDescending(p => p.id).FirstOrDefault().id.ToString();
            }
            catch (Exception)
            {
                return "./1";
                throw;
            }
        }
        public int GetFirstElement()
        {
            try
            {
                datacontext db = new datacontext();
                return  db.haberler.OrderBy(p => p.id).FirstOrDefault().id;
            }
            catch (Exception)
            {
                return 1;
                throw;
            }
        }
        public int GetLastElement()
        {
            try
            {
                datacontext db = new datacontext();
                return db.haberler.OrderByDescending(p => p.id).FirstOrDefault().id;
            }
            catch (Exception)
            {
                return 1;
                throw;
            }
        }
        public string GetAfterElement(HtmlString id)
        {
            try
            {
                int tempid = int.Parse(id.ToString());
                datacontext db = new datacontext();
                return "./"+db.haberler.Where(p => p.id > tempid).OrderBy(p => p.id).FirstOrDefault().id.ToString();
            }
            catch (Exception)
            {
                //En son elementten sonrası bulunamadı
                return "./1";
                throw;
            }
           
          
        }

        public string GetAfterPic(HtmlString id)
        {
            try
            {
                int tempid = int.Parse(id.ToString());
                datacontext db = new datacontext();
                return  db.haberler.Where(p => p.id > tempid).OrderBy(p => p.id).FirstOrDefault().resimuri.ToString();
            }
            catch (Exception)
            {
                //En son elementten sonrası bulunamadı
                return "~~/Content/images/logo.png";
                throw;
            }
        }

        public string GetBeforePics(HtmlString id)
        {

            try
            {
                int tempid = int.Parse(id.ToString());
                datacontext db = new datacontext();
                //   return (db.haberler.Where(p => p.id < Convert.ToInt16(id)).OrderByDescending(p => p.id).FirstOrDefault().id);
                return  db.haberler.Where(p => p.id < tempid).OrderByDescending(p => p.id).FirstOrDefault().resimuri.ToString();
            }
            catch (Exception)
            {
                return "~~/Content/images/logo.png";
                throw;
            }
        }

        public int[,] Pagelist(int pageNow,int manyPage)
        {
           
            manyPage = (manyPage / 14)+1 ;
            int ononce = 0;int uconce = 0;int bironce = 0; int birsonra = 0;int ucsonra = 0;int onsonra = 0; 
            if ((pageNow - 10)>0) { ononce = 1;  }
            if ((pageNow - 3) > 0) { uconce = 1; }
            if ((pageNow - 1) > 0) { bironce = 1; }
            if ((pageNow +1 ) <= manyPage) { birsonra = 1; }
            if ((pageNow + 3) <= manyPage) { ucsonra = 1; }
            if ((pageNow + 10) <= manyPage) { onsonra = 1; }
            return new int[,] { { pageNow-10, ononce }, { pageNow - 3, uconce }, { pageNow - 1, bironce }, { (pageNow + 1), birsonra }, { (pageNow + 3), ucsonra }, { (pageNow + 10), onsonra } };
        }
    }
}