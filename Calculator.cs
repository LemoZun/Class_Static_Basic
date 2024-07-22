namespace Class_Static_Basic
{
    internal class Calculator
    {

        static class MyCalculator // 클래스가 static이 아니더라도 클래스 안의 메소드가 static이면 전역에서 쓸 수 있는데 그럼 클래스 static은 뭐지 
        {
            public static double Add(double a, double b)
            {
                return a + b;
            }
            public static double Subtract(double a, double b)
            {
                return a - b;
            }
            public static double Multiply(double a, double b)
            {
                return a * b;
            }
            public static double Divide(double a, double b)
            {
                if(b != 0)
                {
                    return a / b; 
                }
                else
                {
                    throw new Exception("0으로 나눌 수 없습니다.");
                }                
            }
            public static double Squared(double a, double b)
            {
                
                for(int i = 0; i<b-1 ; i++)
                {
                    a += a;
                }
                return a;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine($" {MyCalculator.Add(1, 2)}");

            Console.WriteLine($" {MyCalculator.Squared(2, 7)}");

            try
            {
                MyCalculator.Divide(10,0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); // 에러메세지 발생
            }
        }
    }
}
