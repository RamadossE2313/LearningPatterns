using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string  Address { get; set; }
        public string JobDescription { get; set; }
        public bool ProjectAssigned { get; set; }
        public string AssignedProjectName { get; set; }
        public string AssignedClient { get; set; }
    }
}
