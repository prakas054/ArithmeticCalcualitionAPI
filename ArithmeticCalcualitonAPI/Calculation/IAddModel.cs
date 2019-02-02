namespace ArithmeticCalcualitonAPI.Calculation
{
    public interface IAddModel
    {
        int Add(int i, int j);
    }

    /// <summary>
    /// 
    /// </summary>
    public class AddModel : IAddModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public int Add(int i, int j)
        {
            return i + j;
        }
    }

}