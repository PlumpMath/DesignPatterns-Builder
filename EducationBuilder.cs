using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderÖvning
{
    public abstract class EducationBuilder
    {
        //public Education education;
        public abstract void AssignTeacher();


        public abstract void InviteStudent();


        public abstract void ProcessStudentFeedBack();


    }
}
