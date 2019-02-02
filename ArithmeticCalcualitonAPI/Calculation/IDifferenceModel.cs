using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCalcualitonAPI.Calculation
{
    public interface IDifferenceModel
    {
        int Sub(int i, int j);
    }

    public class DifferenceModel : IDifferenceModel
    {
        public int Sub(int i, int j)
        {
            return i - j;
        }
    }
}
