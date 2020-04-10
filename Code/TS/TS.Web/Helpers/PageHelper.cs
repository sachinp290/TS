using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TS.Web.Models;

namespace TS.Web.Helpers
{
    public class PageHelper
    {
        public static SelectList GetSelectList(string Entity, string SelectedValue, bool AddSelectItem)
        {
            List<IDNamePair> items = new List<IDNamePair>();
           var res = APIHelper<IDNamePair>.Get("idnamepair?tableName=" + Entity);
           if (items == null)
               items = new List<IDNamePair>();
           else
               items = res.ToList();
            return new SelectList((items),
                                    "ID",
                                    "Name",
                                    SelectedValue);
        }
    }
}