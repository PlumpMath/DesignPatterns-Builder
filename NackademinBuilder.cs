using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderÖvning
{
    public class NackademinBuilder : EducationDirector
    {

        //private Education _education = new Education();

        public NackademinBuilder()
        {
            
        }

        public override void AssignTeacher()
        {

            education.Teacher = "teacher";
        }

        public override void InviteStudent()
        {
            //_education.Student = "student";
            education.Student = "student";
        }

        public override void ProcessStudentFeedBack()
        {
            //_education.StudentFeedback = "feedback";
            education.StudentFeedback = "feedback";
        }

    }
}
