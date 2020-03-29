
namespace TS.Web.Models
{
    public class IDNamePair
    {
        public IDNamePair(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public int ID { get; set; }
        public string Name { get; set; }
    }
}