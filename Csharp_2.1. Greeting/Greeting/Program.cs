namespace Greeting
{
    internal class Program
    {
      //  static void Main(string[] args)  
        static void Main()
        {
            string myName;
            /*   Console.WriteLine("Hello world");
               Console.ReadKey(); */
            Console.WriteLine("Please enter your name");
            myName = Console.ReadLine();
            Console.WriteLine("Hello {0}", myName);
            Console.ReadKey();
        }
    }
}
