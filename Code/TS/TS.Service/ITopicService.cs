using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Entities;

namespace TS.Service
{
    public interface ITopicService
    {
        List<Topic> GetTopics();
        Topic GetTopic(int id);
        void UpdateTopic(Topic item);
        void DeleteTopic(int id);
    }
}
