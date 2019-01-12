using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Ranorex.XMLRestService
{
    class Program
    {
        static void Main(string[] args)
        {
            //http://www.c-sharpcorner.com/uploadfile/dhananjaycoder/self-hosted-wcf-rest-service-or-hosting-wcf-rest-service-in-console-application/

            string port = "9012";
            string baseAddress = $"http://localhost:{port}/";

            printHeader();

            WebServiceHost host = new WebServiceHost(typeof(Service), new Uri(baseAddress));
            try
            {
                host.Open();
                Console.WriteLine("Service Started");
                Console.WriteLine($"Base URL: {baseAddress}");
                Console.WriteLine("Press any key to stop service");
                Console.ReadKey();
            }
            catch (System.ServiceModel.AddressAccessDeniedException ex)
            {
                Console.Write("Exception: " + ex.ToString());
                Console.Write(Environment.NewLine + Environment.NewLine);
                Console.Write("Missing administrative privileges");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.Write("Exception: " + ex.ToString());
                Console.ReadKey();
            }
            finally
            {
                host.Close();
                Console.WriteLine("Service closed.");
            }
            Environment.Exit(0);
        }

        static void printHeader()
        {
            Console.WriteLine(@"▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.WriteLine(@"  ___        ___ ___ ___ _____  __  ____  __ _      ");
            Console.WriteLine(@" | _ \__ __ | _ \ __/ __|_   _| \ \/ /  \/  | |     ");
            Console.WriteLine(@" |   /\ \ / |   / _|\__ \ | |    >  <| |\/| | |__   ");
            Console.WriteLine(@" |_|_\/_\_\ |_|_\___|___/ |_|   /_/\_\_|  |_|____|  ");
            Console.WriteLine(@"▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.WriteLine(string.Empty);
        }
    }
}
