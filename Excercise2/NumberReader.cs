using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    internal class NumberReader
    {
        public delegate void NumberReaderDelegate(int number);
        public event NumberReaderDelegate NumberReaderEvent;
        public void Read()
        {
            Console.WriteLine();
            Console.WriteLine("Выберите способ сортировки: 1 - прямая, 2 - обратная.");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number != 1 && number != 2) throw new InputNumberOutOfRangeException("Значение не соответствует 1 или 2.");
            NumberRead(number);
        }
        protected virtual void NumberRead(int number)
        {
            NumberReaderEvent?.Invoke(number);
        }
    }
}
