using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCalcualitonAPI.Calculation
{
    public interface IProductModel
    {
        int Mul(int i, int j);
    }

   public class ProductModel : IProductModel
    {
        public int Mul(int i, int j)
        {
            return i * j;
        }
    }
}
