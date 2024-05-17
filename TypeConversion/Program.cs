using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try //try catch blocks prevent apps from crashing by throwing an exception
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);

                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);

            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            byte b = 1; //1 byte
            int i = b; //4 bytes
            //this can compile with no data loss
            Console.WriteLine(i);

            int i = 1;
            //byte b = i; //with no cast it cannot compile
            byte b = (byte)i; //compiles cuz of cast (byte)
            Console.WriteLine(i);

            var number = "1234"; //var detects type as string
            int i = (int)number; //cannot be cast cuz it's incompatible
            int i = Convert.ToInt32(number); //compiles thanks to Convert class
            byte b = Convert.ToByte(number); //this crashes the app
            Console.WriteLine(b); //causes an exception/error that says "Value is either too large or too small"



        }
    }
}

