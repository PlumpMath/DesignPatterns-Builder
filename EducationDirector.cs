using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderÖvning
{
    
    public class EducationDirector : EducationBuilder
    {
        public readonly Education education = new Education();

        public Education Build(EducationBuilder build)
        {
            build.AssignTeacher();
            build.InviteStudent();
            build.ProcessStudentFeedBack();

            return education;
        }

        public override void AssignTeacher()
        {
            education.Teacher = "teacher";
        }

        public override void InviteStudent()
        {
            throw new NotImplementedException();
        }

        public override void ProcessStudentFeedBack()
        {
            throw new NotImplementedException();
        }
    }
}
