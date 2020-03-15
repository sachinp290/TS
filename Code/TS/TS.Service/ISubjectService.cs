using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Entities;

namespace TS.Service
{
    public interface ISubjectService
    {
        List<Subject> GetSubjects();
        Subject GetSubject(int id);
        void UpdateSubject(Subject value);
    }
}
