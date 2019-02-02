namespace ArithmeticCalcualitonAPI.Calculation
{
    public interface IDivideModel
    {
        int Div(int i, int j);
    }

    public class DivideModel :IDivideModel
    {
        public int Div(int i, int j)
        {
            return i/j;
        }
    }
}
