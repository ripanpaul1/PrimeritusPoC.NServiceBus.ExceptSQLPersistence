
using System;
using System.Configuration;
using System.Collections.Generic;
using Lateetud.NServiceBus.Common;
using Lateetud.NServiceBus.Common.Models.Primeritus;
using System.ServiceProcess;

namespace Lateetud.NServiceBus.Subscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            //ServiceBase[] serviceBase;
            //serviceBase = new ServiceBase[]
            //{
            //    new PrimeritusPoCNServiceBus()
            //};
            //ServiceBase.Run(serviceBase);



            new PrimeritusPoCNServiceBus().debug();
            var key = Console.ReadKey();

        }

        public void ServiceConfig()
        {
            MsmqSqlDBConfiguration msmqsqldbconfig = new MsmqSqlDBConfiguration("", ConfigurationManager.AppSettings["ErrorQueue"], 50, 5);

            List<PublisherEndpoints> publisherEndpoints = new List<PublisherEndpoints>();
            publisherEndpoints.Add(new PublisherEndpoints(endpointName: ConfigurationManager.AppSettings["PublisherQueue"], messageType: typeof(VMXml)));
            var endpointConfiguration = msmqsqldbconfig.ConfigureEndpoint(ConfigurationManager.AppSettings["SubscriberQueue"], publisherEndpoints);
            msmqsqldbconfig.CreateEndpointInitializePipeline(endpointConfiguration).GetAwaiter().GetResult();
        }
    }
}
