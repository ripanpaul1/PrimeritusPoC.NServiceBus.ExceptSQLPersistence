using System.Threading.Tasks;
using NServiceBus;
using Lateetud.NServiceBus.Common.Models.Primeritus;
using Lateetud.NServiceBus.Subscriber.LibClasses;
using LateetudService.LibClasses;
using System;
using System.Threading;

namespace Lateetud.NServiceBus.Subscriber
{
    public class XmlHandler :
        IHandleMessages<VMXml>
    {
        public Task Handle(VMXml message, IMessageHandlerContext context)
        {
            try
            {
                string TheFileContent = new AuraService().XmlToAuraString(message.Message);
                if (TheFileContent == null) return Task.FromCanceled(new CancellationToken(true));
                //if (!new PrimeritusXmlService().IsSendAura(TheFileContent)) return Task.FromCanceled(new CancellationToken(true));
                return Task.CompletedTask;
            }
            catch (Exception err)
            {
                return Task.FromCanceled(new CancellationToken(true));
            }
        }
    }
}


