using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.Exceptions
{
    public class NameException : Exception
    {
        public NameException(string message) :
            base(message)
        {
        }
    }
}
