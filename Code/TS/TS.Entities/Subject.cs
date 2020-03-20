using System;
using System.Data;
namespace TS.Entities
{
    public class BaseEntity
    {

    }
    public class Subject : BaseEntity
    {
        public Subject() { }
        public Subject(IDataReader reader)
        {
            ID = Convert.ToInt32(reader["ID"]);
            Name = Convert.ToString(reader["Name"]);
        }
        public int ID { get; set; }
        public string Name { get; set; }

    }
}
