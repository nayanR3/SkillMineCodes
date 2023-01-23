using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForm
{
    [Serializable]
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Percentage { get; set; }

        public string Department { get; set; }
    }
}
