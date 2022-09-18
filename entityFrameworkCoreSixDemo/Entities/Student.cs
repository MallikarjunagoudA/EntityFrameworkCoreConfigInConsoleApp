using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityFrameworkCoreSixDemo.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public int age { get; set; }
    }
}
