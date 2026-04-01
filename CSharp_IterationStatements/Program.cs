using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_IterationStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                whileLoop();
                forLoop();
                dowhileLoop();
                foreachLoop();


            }
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
			finally
			{ 
                       Console.ReadLine();
            }
        }

        private static void foreachLoop()
        {
            string[] friends = { "John", "Diana", "James", "Francesca" };

            foreach (string friend in friends)
            {
                Console.Write(friend + " ");
            }
            Console.WriteLine();
        }

        private static void dowhileLoop()
        {
            int timesTable = 10;
            int start1 = 11;
            int end1 = 20;

            do
            {
                int product = timesTable * start1;
                Console.WriteLine($"{timesTable} * {start1} = {product}");
                start1++;
            } while (start1 <= end1);
            Console.WriteLine(":::::::::::::::");
        }

        private static void forLoop()
        {
            int timesTable = 45;
            int start2 = 21;
            int end2 = 30;

            for (int i = start2; i <= end2; i++)
            {
                int product = timesTable * i;
                Console.WriteLine($"{timesTable} * {i} = {product}");
            }
            Console.WriteLine(":::::::::::::::");
        }

        private static void whileLoop()
        {
            int timesTable = 45;
            int start = 1;
            int end = 10;

            while (start <= end)
            {
                int product = timesTable * start;
                Console.WriteLine($"{timesTable} * {start} = {product}");
                start++;
            }
            Console.WriteLine(":::::::::::::::");
        }
    }
}
