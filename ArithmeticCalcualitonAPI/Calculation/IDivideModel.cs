using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCalcualitonAPI.Calculation
{
    public interface IDivideModel
    {
        int div(int i, int j);
    }

    public class DivideModel :IDivideModel
    {
        public int div(int i, int j)
        {
            return i/j;
        }
    }
}
