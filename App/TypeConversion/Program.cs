using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;

            Console.WriteLine(i);

            string number = "1234";
            int j = Convert.ToInt32(number);
            Console.WriteLine(j);

            try
            {
                var number2 = "1234";
                byte b1 = Convert.ToByte(number2);
                Console.WriteLine(b1);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }

            try
            {
                string str = "true";
                bool bo = Convert.ToBoolean(str);
                Console.WriteLine(bo);
            }
            catch (Exception)
            {
                Console.WriteLine("Could not convert to boolean");
            }
        }
    }
}
