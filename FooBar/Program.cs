namespace FooBar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int count = 1; count <= 100; count++)
            {
                if (count % 3 == 0)
                {
                    Console.Write("Foo");
                }
                if (count % 5 == 0)
                {
                    Console.Write("Bar");
                }
                if (count % 5 != 0 && count % 3 != 0)
                {
                    Console.Write(count);
                }
                Console.WriteLine();

            }

        }

    }

}
