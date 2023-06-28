namespace Excercise2
{
    internal class Program
    {
        static List<string> lastName = new List<string>()
            {
                "Лавлейс",
                "Тьюринг",
                "Хоппер",
                "Пейдж",
                "Брин"
            };
        static void Main(string[] args)
        {
            NumberReader numberReader = new NumberReader();
            numberReader.NumberReaderEvent += SortLastName;
            while (true)
            {
                try
                {
                    numberReader.Read();
                    ShowLastName();
                    break;
                }
                catch (InputNumberOutOfRangeException ie)
                {
                    Console.WriteLine(ie.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено некорректное значение.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Непредвиденная ошибка.");
                }
                finally
                {
                    Console.WriteLine("=====================================================");
                }
            }
        }
        static void ShowLastName()
        {
            foreach (string lastName in lastName)
            {
                Console.WriteLine(lastName);
            }
        }
        static void SortLastName(int number)
        {
            lastName.Sort();
            if (number == 2) lastName.Reverse();
        }
    }
}