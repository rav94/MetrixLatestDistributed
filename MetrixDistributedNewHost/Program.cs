using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MetrixDistributedNewHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = null;
            try
            {
                

                using (host = new ServiceHost(typeof(MetrixDistributedNew.MetrixDistributedService)))
                {
                    foreach (var endpoint in host.Description.Endpoints)
                    {
                        Console.WriteLine(endpoint.Address.Uri);
                    }

                    host.Open();
                    Console.WriteLine("The Metrix Distrbuted Service started at : " + DateTime.Now.ToString());
                    Console.ReadLine();
                }
            }

            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(string.Format("Host error:\r\n{0}:\r\n{1}", ex.GetType(), ex.Message));
                Console.ReadLine();
            }

            finally
            {
                // memory clean
                if (host != null)
                    ((IDisposable)host).Dispose();
            }
        }
        }
    }

