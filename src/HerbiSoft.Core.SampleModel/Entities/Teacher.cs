using System.Collections.Generic;

namespace HerbiSoft.Core.SampleModel.Entities
{
    public class Teacher : Person
    {
        public string Type { get; set; }

        public List<Course> Courses { get; set; }
    }
}
