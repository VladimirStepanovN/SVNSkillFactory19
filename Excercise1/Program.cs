namespace Excercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] exception = { new MyException("Свой тип исключения", 10000), new DivideByZeroException(),
                new IndexOutOfRangeException(), new FileNotFoundException(), new KeyNotFoundException() };
            foreach(Exception ex in exception)
            {
                try
                {
                    throw ex;
                }
                catch (Exception)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Блок finally выполняется всегда.");
                }
            }
        }
    }
}