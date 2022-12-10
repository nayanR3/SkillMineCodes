using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.WrittenTest.Dec10
{
    /*Q2. Swap values of two integer variables without using third variable.*/
    public class DecQ2
    {
        public int A { get; set; }
        public int B { get; set; }

        public void Cal( )
        {
            A = A + B;
            B = A - B;
            A = A - B;
        }
        public override string ToString()
        {
            return $"A= {A} and B= {B}";
        }

    }
}
