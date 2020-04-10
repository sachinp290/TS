using System.Linq;
using System.Web.Mvc;
using TS.Web.Models;

namespace TS.Web.Helpers
{
    public class PageHelper
    {
        public static SelectList GetSelectList(string Entity, string SelectedValue, bool AddSelectItem)
        {
            var items = APIHelper<IDNamePair>.Get("idnamepair?tableName=" + Entity)?.ToList();            
            return new SelectList((items),
                                    "ID",
                                    "Name",
                                    SelectedValue);
        }
    }
}