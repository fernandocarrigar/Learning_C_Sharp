using System;


namespace MyApplication
{
    class Program
    {
        static void Main()
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                    Console.WriteLine(myNumbers[10]);
            }
            catch (Exception f)
            {
                Console.WriteLine(f.Message);
            }
            finally
            {
                Console.WriteLine("Trata de modificar el codigo");
            }
        }
    }
}