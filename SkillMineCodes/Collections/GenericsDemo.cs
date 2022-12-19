using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.Collections
{
    public class GDemo<t>
    {
        private t  data;
        public  GDemo(t data) {
            this.data = data;
        }

        public override string ToString()
        {
            return $"{data}";
        }
    }
}
