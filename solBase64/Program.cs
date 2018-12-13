using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solBase64
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainText = " ";
            string base64EncodedData;
            int n;

            Console.WriteLine("Inserisci unnumero");
            n = Convert.ToInt32(Console.ReadLine());

            string ascii = System.Text.ASCIIEncoding.ASCII.GetString(new byte[] { (byte)n });

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine(ascii);

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("Inserisci una parola");
            plainText = Console.ReadLine();

            byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            for (int i = 0; i < plainTextBytes.Length; i++)
            {
                Console.WriteLine(plainTextBytes[i]);
                Console.WriteLine(Convert.ToString(plainTextBytes[i], 2));
            }
            
            base64EncodedData = Convert.ToBase64String(plainTextBytes);
            Console.WriteLine("La codifica in base 64 della parola '" + plainText + "' è " + base64EncodedData);

            byte[] base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            plainText = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            Console.WriteLine(plainText);

            Console.ReadLine();
        }
    }
}
