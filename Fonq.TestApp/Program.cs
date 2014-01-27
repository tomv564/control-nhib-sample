using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fonq.Control.Data;
using Fonq.Control.Entities;
using NHibernate;
using NHibernate.Linq;
using NHibernate.Criterion;
using log4net;

namespace Fonq.TestApp
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            //HibernatingRhinos.Profiler.Appender.NHibernate.NHibernateProfiler.Initialize();

            if (log.IsInfoEnabled)
                log.Info("Parsing arguments");

            if (args.Length == 0)
            {
                PrintInstructions();
                return;
            }

            if (log.IsInfoEnabled)
                log.Info("Searching customers...");

            ListCustomers(args[0]);

            if (log.IsInfoEnabled)
                log.Info("Search complete.");

            return;
        }

        private static void PrintInstructions()
        {
            Console.WriteLine("Usage: Fonq.TestApp {name}");
        }


        private static void ListCustomers(string filter)
        {
            ISessionFactory factory = ControlDatabase.CreateSessionFactory();
            IList<Customer> customers = new List<Customer>();
            using (var session = factory.OpenSession())
            {
                // TODO: build IsLike for Linq provider queries.
                customers = session.QueryOver<Customer>()
                                    .WhereRestrictionOn(c => c.Name)
                                    .IsLike(string.Format("%{0}%", filter))
                                    .Fetch(c => c.InvoiceAddress).Eager
                                    .List<Customer>();

                Console.WriteLine("{0} customer(s) found", customers.Count);
                foreach (var customer in customers)
                {
                    Console.WriteLine("{0, -30} {1}", customer.Name, customer.InvoiceAddress.City);
                }
            }
          
        }

    }
}
