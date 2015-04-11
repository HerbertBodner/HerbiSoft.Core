using System.Collections.Generic;

namespace HerbiSoft.Core.SampleModel.Entities
{
    public class Student : Person
    {
        public List<Course> Courses { get; set; }
    }
}
