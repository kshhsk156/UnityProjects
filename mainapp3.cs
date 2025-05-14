//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2025_04_28_csharp
//{
//    internal class mainapp3
//    {

//        //참조에 의한 매개변수 전달
//        public static void Swap(ref int a, ref int b, ref int c)//ref : 주소를 가진다, 호출 후 다음줄 기억함
//        {
            
//            int temp = c;
//            c = a;
//            a = temp;
        
//        }
//        public static void Swap(ref int a, ref int b)
//        {
//            int temp = a;
//            b = a;
//            a = temp;
//            Console.WriteLine($"{a} {b}");
//        }
//        public static void Swap(ref float a, ref float b)
//        {

//        }
//        static void Main(string[] args)
//        {

            //호출 한 후 다음 줄에서 메모리가 사라짐
            //int a = 3;
            //int b = 5;
            //Console.WriteLine($"a: {a}, b: {b} ");
            //Swap(ref a, ref b);
            //Console.WriteLine($"a: {a}, b: {b} ");

           

//            int a = 3;
//            int b = 5;
//            int c = 7;
//            Console.WriteLine($"a : {a}, b: {b}, c:{c}");
//            Swap(ref a, ref b, ref c);             //호출 한 후 다음 줄에서 메모리가 사라짐
//            Console.WriteLine($"a : {a}, b: {b}, c:{c}");

//        }
//    }
//}
