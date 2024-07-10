namespace ClassLibraryConsole
{
    public class DefaultFunctions
    {
        public double Soma(params double[] args)
        {
            double result = 0;

            foreach (var value in args)
            {
                result += value;
            }

            return result;
        }
    }
}
