using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfuck
{
    public static class BitPrac
    {
        public static void BitTest()
        {
            int a = 0b0001_0000;
            Console.WriteLine(Convert.ToString(a, 2));
            //== 비트 쉬프트 : << 또는 >>에서 오른쪽에 적힌 정수만큼 왼쪽 값의 비트를 옮긴다 
            //옮겼을때 1의 비트가 잘리는 구조가 되면, 해당하는 1의 비트들은 0으로 바껴서, 잘린것으로 처리된다.
            a = a >> 0b0101;
            Console.WriteLine(Convert.ToString(a,2));
            a = a << 0b0101;
            Console.WriteLine(Convert.ToString(a, 2));

            Console.WriteLine("========");
            //== & 연산자 : & 양쪽의 수의 비트중에서, 둘 다 1인것만 1로 저장한다
            int b = 0b0100;
            int c = 0b0110;

            Console.WriteLine(b);
            Console.WriteLine(c);

            b &= c;

            Console.WriteLine(b);

            c &= b;

            Console.WriteLine(c);

            Console.WriteLine("========");
            //== | 연산자 : | 양쪽의 수의 비트중에서, 둘중 하나라도 1인것만 1로 저장한다
            int d = 0b0011;
            int e = 0b0100;

            Console.WriteLine(d);
            Console.WriteLine(e);

            d |= e;

            Console.WriteLine(d);
            d = 0b0011;

            e |= d;

            Console.WriteLine(e);

            Console.WriteLine("========");
            //== ^ 연산자 : ^ 양쪽의 수의 비트중에서,둘이 다른것만 1로 저장한다
            /*
            * ==법칙 1
            * a'와 a는 ^= b 연산을 통해 서로로 바뀔수 있다 ==>   a ^= b <=> a' ^= b
            * 여기서 a'또는 a가 아니더라도, a와 같은 값을 가진 다른 변수에 ^= b연산을 수행하면 a'의 값으로,
            *      a'와 같은 값을 가진 다른 변수에 ^= b연산을 수행하면, a의 값으로 변한다
            * 
            * 
            * == 법칙 2
            * 한 변수에 모든 비트가 1인 다른 변수를 ^=  계산을 하거나 당하면, 그 변수는 값이 반전된다 
            * 그리고, 다른 변수가 0이면, 변수는 값이 그대로 유지된다
            * 
            * == 법칙 3
            * 변수 a와 b가 있고, a와 b의 비트값은 완전히 반대된다고 가정할때 (ex. a = 0110, b = 1001같은),
            * L ^= R 연산을 하면 L위치에 있는 변수의 비트값은 무조건 모든 0이라는 값을 가지고 있는 비트는 1이라는 값을 저장하는 상태로 바뀐다.
            * 
            * ==법칙 4
            * 변수 a와 b가 있다고 가정했을때, a ^= b와 b ^= a의 값은 같다
            */

            int f = 0b0101;
            int g = 0b0110;

            Console.WriteLine(f);
            Console.WriteLine(g);

            f ^= g;

            Console.WriteLine(f);
            f = 0b0101;

            g ^= f;
            Console.WriteLine(g);
            Console.WriteLine("========");




            //== ~연산자 : ???


        }
        public static void BitMaskTest()
        {
            
        }
        [Flags]
        public enum TestEnum
        {
            Test1 = 0x01,
            Test2 = 0x02,
            Test3 = 0x03,
            Test4 = 0x04,
            Test5 = 0b0101,
            Test6 = 0b0110,
            Test7 = 0b0111,
            Test8 = 0b1000,
            Test9 = 0b1001,
            Test10 = 0b1010
        }

        public static void BitSwapTest()
        {
            int a = 0b1010;
            int b = 0b0110;
            Console.WriteLine(a);
            Console.WriteLine(b);
            // a = 1010 
            // b = 0110


            a ^= b; // a' = 1100  b = 0110 ==> a'는 a와b의 차이비트(같지 않은 비트) 들만 저장함
            b ^= a; // a' = 1100  b' = 1010 ==> b'는 a'와 b의 차이비트들만 저장함
            a ^= b; // a'' = 0110  b' = 1010 ==> a''는 a'와 b'의 차이비트들만 저장함
            Console.WriteLine(a);
            Console.WriteLine(b);

            /*
             * ==법칙 1
             * a'와 a는 ^= b 연산을 통해 서로로 바뀔수 있다 ==>   a ^= b <=> a' ^= b
             * 여기서 a'또는 a가 아니더라도, a와 같은 값을 가진 다른 변수에 ^= b연산을 수행하면 a'의 값으로,
             *      a'와 같은 값을 가진 다른 변수에 ^= b연산을 수행하면, a의 값으로 변한다
             * 
             * 
             * == 법칙 2
             * 한 변수에 모든 비트가 1인 다른 변수를 ^=  계산을 하거나 당하면, 그 변수는 값이 반전된다 
             * 그리고, 다른 변수가 0이면, 변수는 값이 그대로 유지된다
             * 
             * == 법칙 3
             * 변수 a와 b가 있고, a와 b의 비트값은 완전히 반대된다고 가정할때 (ex. a = 0110, b = 1001같은),
             * L ^= R 연산을 하면 L위치에 있는 변수의 비트값은 무조건 모든 0이라는 값을 가지고 있는 비트는 1이라는 값을 저장하는 상태로 바뀐다.
             * 
             * ==법칙 4
             * 변수 a와 b가 있다고 가정했을때, a ^= b와 b ^= a의 값은 같다
             * 
             * 
             * 
             * b'와 b는 b ^= a' 연산을 통해 서로로 바뀔수 있다 b ^= a' <=> b' ^= a'
             * a는 b ^= a' 와 같다 ==>  a == b^a'
             * b는 a' ^= b' 와 같다 ==>  b == a' ^= b'
             * 
             * ex:
             * a = 01
             * b = 11
             * 
             * a ^= b;  ==> 01 과 11에서 첫자리는 0과 1로 다르므로, 첫째자리는 1로 저장되고, 둘째자리는 1과 1로 같으므로, 둘쨰자리는 0으로 저장된다.
             *              따라서, 첫째자리는 1, 둘째자리는 0으로, 10, a의 저장된 비트는 반전된다
             * a == 10
             * 
             * a ^= b;  ==> 10과 11에서 첫자리는 1과 1로 같으므로, 첫쨰잘리는 0으로 저장되고, 둘째자리는 0과 1로 다르므로, 둘째자리는 0으로 저장된다.
             *              따라서, 첫째자리가 0, 둘쨰자리가 1로, 01, a에 저장된 비트는 다시 반전되어 원레의 a의 비트 데이터로 돌아간다.
             * 
             * a == 01
             *  
             *  
             *  
             *  
             *  ===============
             *  
             *  
             *  
             *  
             *  a = 01
             *  b = 11
             *  
             *  a ^= b; ==> 01 과 11에서 첫자리는 0과 1로 다르므로, 첫째자리는 1로 저장되고, 둘째자리는 1과 1로 같으므로, 둘쨰자리는 0으로 저장된다.
             *              따라서, 첫째자리는 1, 둘째자리는 0으로, 10, a의 저장된 비트는 반전된다 
             *              a == 10
             *  
             *  b ^= a; ==> 11과 10에서 첫자리는 1과 1로 같으므로, 첫째자리는 0으로 저장되고, 둘째자리는 1과 0으로 다르므로, 둘쨰자리는 1로 저장된다.
             *              따라서, 첫째자리는 0, 둘째자리는 1로, 01로, 즉, a의 계산 전 값으로 저장된다.
             *              b == 01
             *              연관 법칙 ==> 법칙1
             *              
             *              
             *  a ^= b  ==> 10과 01에서 첫째자리는 1과 0으로 다르므로 1로 저장되고, 둘째자리는 0과 1로 다르므로, 둘째자리도 1로 저장된다.
             *              따라서, 첫째자리는 1, 둘째자리는 1로, 11, 즉 , b의 계산 전 값으로 저장된다.
             *              연관 법칙 ==> 법칙1
             *              
             *              a == 11, b == 01
             *  
             *  
             *  ===========
             *  
             *  a = 01
             *  b = 10
             *  
             *  a ^= b  ==> 01과 10에서 첫째자리는 0과 1로 다르므로, 첫째자리는 1로 저장되고, 둘째자리는 1과 0으로 다르므로, 둘쨰자리도 1로 저장된다.
             *              따라서, 첫째자리가 1, 둘째자리가 1로 저장된다.
             *              a == 11
             *              연관법칙 ==> 법칙 3
             *              
             *  
             *  b ^= a  ==> 10과 11에서 첫째자리는 1과 1로 같으므로, 첫째자리는 0으로 저장되고, 둘째자리는 1과 0으로 다르므로, 둘째자리는 1로 저장된다.
             *              따라서, 첫째자리가 0, 둘째자리가 1, 즉, a의 계산 전 값으로 저장된다.
             *              b == 01
             *              연관법칙 ==> 법칙 2
             *              
             *              
             *  a ^= b  ==> 11과 01에서 첫째자리는 1과 0으로 다르므로, 첫째자리는 1로 저장되고, 둘째자리는 1과 1로 다르므로, 0으로 저장된다.
             *              따라서, 첫째자리가 1, 둘째자리가 0으로, 즉, b의 계산 전 값으로 저장된다.
             *              a == 10, b == 01
             *              연관법칙 ==> 법칙 2
             *  
             *  
             * 
             */



            int aa = 0b10;
            int bb = 0b00;
            int cc = 0b11;
            Console.WriteLine(aa);
            Console.WriteLine(aa ^= bb);
            Console.WriteLine(aa ^= cc);

            int bd = 0b1100;
            int bc = 0b1100;
            bd ^= bc; // bd = 0000 bc = 1100
            bc ^= bd; // bd = 0000 bc = 1100
            bd ^= bc; // bd = 1100 bc = 1100
            Console.WriteLine(bd);
            Console.WriteLine(bc);

            Console.WriteLine();











            /*
            var c = 0xc000_0000_0000;
            Console.WriteLine(c);
            */
        }
    }
}
