using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    
    delegate float MulOrDivOrPlus(int p1, int p2);

    class Program
    {
        //Методы, реализующие делегат. Сложение, умножение и деление
        static float Plus(int p1, int p2) { return p1 + p2; }
        static float Mul(int p1, int p2) { return p1 * p2; }
        static float Div(int p1, int p2) { return p1 / p2; }
        

        
        static void MulOrDivOrPlusMethod(string str, int i1, int i2, MulOrDivOrPlus MulOrDivOrPlusParam)
        {
            float Result = MulOrDivOrPlusParam(i1, i2);
            Console.WriteLine(str + Result.ToString());
        }
        static void mulordivMethodFunc(string str, int i1, int i2, Func<int, int, float> MulOrDivOrPlusParam)
        {
            float Result = MulOrDivOrPlusParam(i1, i2);
            Console.WriteLine(str + Result.ToString());
        }
        

        static void Main(string[] args)
        {
            int i1 = 6;
            int i2 = 2;

            MulOrDivOrPlusMethod("Умножение: ", i1, i2, Mul);
            MulOrDivOrPlusMethod("Деление: ", i1, i2, Div);
            MulOrDivOrPlusMethod("Сложение: ", i1, i2, Plus);

            MulOrDivOrPlusMethod("Создание экземпляра делегата на основе лямбда-выражения 1: ", i1, i2,
            (int x, int y) =>
            {
                int z = x * y;
                return z;
            }
             );
            MulOrDivOrPlusMethod("Создание экземпляра делегата на основе лямбда-выражения 2: ", i1, i2,
            (x, y) =>
            {
                return x * y;
            }
             );
            MulOrDivOrPlusMethod("Создание экземпляра делегата на основе лямбда-выражения 3: ", i1, i2, (x, y) => x / y);

            Console.WriteLine("\nИспользование обощенного делегата Func<>");
            mulordivMethodFunc("Создание экземпляра делегата на основе метода:", i1, i2, Div);
        

        }
    }
}
