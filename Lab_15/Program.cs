using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15
{
    internal class Program
    {

    }
    public interface ISerie //генерации ряда чисел.
    {
        void setStart(int x); //устанавливает начальное значение
        int getNext(); // возвращает следующее число ряда
        void reset(); // выполняет сброс к начальному значению
    }
    public class ArithProgression : ISeries // реализация интерфейса
    {
        int start;
        int val;
        public ArithProgression()
        {
            start = 0;
            val = 0;
        }
        public void SetStart(int x)
        {
            start = x;
            val = start;
        }
        public int GetNext()
        {
            val += 2;
            return val;
        }
        public void Reset()
        {
            val = start;
        }

        object ISeries.GetNext()
        {
            throw new NotImplementedException();
        }

        class GeomProgression : ISeries // реализация интерфейса
        {
            int start;
            int val;
            public GeomProgression()
            {
                start = 2;
                val = 2;
            }
            public void SetStart(int x) // устанавливает начальное значение
            {
                start = x;
                val = start;
            }

            public int GetNext() //возвращает следующее число ряда
            {
                val *= 2;
                return val;
            }

            public void Reset() //выполняет сброс к начальному значению
            {
                val = start / 2;
            }

            object ISeries.GetNext()
            {
                throw new NotImplementedException();
            }
            class SeriesDemo1
            {
                static void Main()
                {
                    Console.WriteLine("Арифметическая");
                    ArithProgression ob1 = new ArithProgression();

                    for (int i = 0; i < 5; i++)
                        Console.WriteLine("Следующее число равно " + ob1.GetNext());
                    Console.WriteLine("\nНачать с числа 2");
                    ob1.SetStart(2);
                    for (int i = 0; i < 5; i++)
                        Console.WriteLine("Следующее число равно " + ob1.GetNext());
                    for (int i = 0; i < 5; i++)
                        Console.WriteLine("Следующее число равно " + ob1.GetNext());
                    ob1.Reset();
                    Console.WriteLine("Геометрическая");
                    GeomProgression ob = new GeomProgression();

                    for (int i = 0; i < 5; i++)
                        Console.WriteLine("Следующее число равно " + ob.GetNext());
                    Console.WriteLine("\nНачать с числа 2");
                    ob.SetStart(2);
                    for (int i = 0; i < 5; i++)
                        Console.WriteLine("Следующее число равно " + ob.GetNext());
                    for (int i = 0; i < 5; i++)
                        Console.WriteLine("Следующее число равно " + ob.GetNext());
 
                    ob.Reset();
                    Console.ReadKey();
                  
                }
            }
        }
    }
}


