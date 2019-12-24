using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using MSSQLBase;
using ServiceWCF;

namespace ServiceHost
{
    class Program
    {
        static void Main()
        {
            WozapDatabaseDataContext db1 = new WozapDatabaseDataContext();
            var db = new MSSQL(db1);
            var service = new Service(db);
            using (System.ServiceModel.ServiceHost host = new System.ServiceModel.ServiceHost(service, new Uri("localhost:8080")))
            {
                try
                {
                    host.Open();
                    Console.WriteLine("host started!\n");
                    Console.ReadLine();

                    host.Close();
                }
                catch (TimeoutException timeProblem)
                {
                    Console.WriteLine(timeProblem.Message);
                    Console.ReadLine();
                }
                catch (CommunicationException commProblem)
                {
                    Console.WriteLine(commProblem.Message);
                    Console.ReadLine();
                }
            }
        }
    }
}