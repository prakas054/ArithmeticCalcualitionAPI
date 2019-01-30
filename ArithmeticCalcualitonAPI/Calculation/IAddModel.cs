using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCalcualitonAPI.Calculation
{
    public interface IAddModel
    {
        int add(int i, int j);
    }


    public class AddModel : IAddModel
    {
        public int add(int i, int j)
        {
            return i + j;
        }
    }

}