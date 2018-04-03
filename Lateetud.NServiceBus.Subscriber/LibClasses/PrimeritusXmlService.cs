using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

namespace Lateetud.NServiceBus.Subscriber.LibClasses
{
    public class PrimeritusXmlService
    {
        public bool IsSendAura(string aurastring)
        {
            try
            {
                //com.renovo.test.aptest.RequestAssignment assignment = new com.renovo.test.aptest.RequestAssignment();
                //System.Net.ServicePointManager.ServerCertificateValidationCallback = ((sender, cert, chain, errors) => cert.Subject.Contains("test.renovo.com"));
                //assignment.Credentials = new NetworkCredential("rpaul", "Recovery@1991");
                //if (assignment._RequestAssignment(aurastring) <= 0) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        
    }
}
