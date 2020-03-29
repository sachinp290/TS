using System.Linq;
using System.Web.Mvc;
using TS.Web.Models;

namespace TS.Web.Helpers
{
    public class PageHelper
    {
        public static SelectList GetSelectList(string Entity, string SelectedValue, bool AddSelectItem)
        {
            var items = APIHelper<IDNamePair>.Get("idnamepair?tableName=" + Entity).ToList();
            if (AddSelectItem)
                items.Insert(0, new IDNamePair(0, "Select"));
            return new SelectList((items),
                                    "ID",
                                    "Name",
                                    SelectedValue);
        }
    }
}