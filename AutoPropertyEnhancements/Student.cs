using System.Collections.Generic;

namespace AutoPropertyEnhancements
{
    public class Student
    {
        public string FirstName { get; set; } = "Ivan";

        public string LastName { get; set; } = "Ivanov";

        public List<string> Skills { get; set; } = new List<string>()
        {
            "C#",
            "JavaScript",
            ".NET",
            "NodeJS"
        };

        public override string ToString()
        {
            string strSkills = string.Join(", ", this.Skills.ToArray());

            string tmpl = string.Format("Hello, my name is {0} {1} and my skills are: {2}", this.FirstName, this.LastName, strSkills);

            return tmpl;
        }
    }
}
