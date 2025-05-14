//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////출력 전용 매개 변수
//namespace _2025_04_28_csharp
//{
//    internal class mainapp4
//    {
//        //out 매개 변수는 반드시 초기화 해야함
//        //매서드 안에서 결과가 나오지 않고 매개변수로 나와서 전달됨
//        //out과 ref의 차이
//        static void Divide(int a, int b, out int c, out int d)
//        {
//            //결과 값이

//            c = a / b;
//            d = a % b;


//        }
//        //가변 개수의 인수 
//        static int Sum(params int[] numbers)
//        {
//            int sum = 0;
//            for (int i = 0; i < numbers.Length; i++)
//            {
//                sum += numbers[i];
//            }
//            Console.WriteLine();
//            return sum;
//        }
//        static void Main(string[] args)
//        {
//            //int a = 20;
//            //int b = 3;
//            //Divide(a, b, out int c, out int d);
//            //Console.WriteLine($" a : {a} b, {b}, a / b : {c} a % b : {d}");
//            //매개 변수를 주소로 전달하고 싶을때 쓰는 기능
//            int sum = Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
//            int sum2 = Sum(1, 2, 3, 4, 5);
//            Console.WriteLine($"sum: {sum}, sum2 {sum2}");
//            //매개 변수를 몇개든지 전달 가능하게 하는 기능 params int[] 

//        }
//    }

//}
