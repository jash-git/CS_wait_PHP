using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2PHPforJson
{
    class Program
    {
        static void Pause()
        {
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        static void Main(string[] args)
        {
            String StrData = "{\"firstName\": \"Jash\",\"lastName\":\"Liao\"}";
            String StrUrl = "http://localhost:8080/php_sleep.php";
            Console.WriteLine("C# send Data- " + StrData);
            Console.WriteLine("PHP url: " + StrUrl);
            Console.WriteLine("-----------------------------------------------------------------");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("C# start time- "+DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                Console.WriteLine("\tphp: "+CS2PHPrestfulapi.RESTfulAPI_postBody(StrUrl, StrData));
                Console.WriteLine("C# end time- " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                Console.WriteLine("-----------------------------------------------------------------");
            }
            Pause();
        }
    }
}
