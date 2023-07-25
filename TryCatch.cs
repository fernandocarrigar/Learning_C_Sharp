using System;


namespace MyApplication
{
    class Program
    {
        public int[] myNumbers = { 1, 2, 3 };

        //public int[] MyNumbers{ get; set;} 

        public Program() { }

        public static void ArryTry(int[] numbrs)
        {
            try
            {
                Console.WriteLine(numbrs[10]);
            }
            catch (Exception f)
            {
                Console.WriteLine(f.Message);
            }
            finally
            {
                Console.WriteLine(numbrs[2]);
                Console.WriteLine("Trata de modificar el codigo");
            }
        }

        //public static void Main()
        //{
        //    Program c = new Program();
        //    ArryTry(c.myNumbers);
        //}
    }
}