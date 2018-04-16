using System;
using System.Configuration;
using System.Net;
using Lateetud.Utilities;
using System.IO;

namespace Lateetud.NServiceBus.Subscriber.LibClasses
{
    public class PrimeritusXmlService
    {
        public bool IsSendAura(string aurastring, string RequestType)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(RequestType))
                {
                    ServicePointManager.ServerCertificateValidationCallback = ((sender, cert, chain, errors) => cert.Subject.Contains("test.renovo.com"));
                    if (RequestType == "1")
                    {
                        com.renovo.test.aptest.RequestAssignment assignment = new com.renovo.test.aptest.RequestAssignment();
                        assignment.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["AuraUserName"], ConfigurationManager.AppSettings["AuraPassword"]);
                        if (assignment._RequestAssignment(aurastring) <= 0) return false;
                    }
                    else if (RequestType == "2")
                    {
                        com.renovo.test.aptest1.EM1_ASG_NOTE_UPDATE assignment = new com.renovo.test.aptest1.EM1_ASG_NOTE_UPDATE();
                        assignment.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["AuraUserName"], ConfigurationManager.AppSettings["AuraPassword"]);
                        if (assignment._EM1_ASG_NOTE_UPDATE(aurastring) <= 0) return false;
                    }
                    return true;
                }
                return false;
            }
            catch (Exception err)
            {
                return false;
            }
        }

        public bool IsTextFileCreation(string aurastring, string RequestType, string rootPath)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(RequestType))
                {
                    string DirectoryPath = Path.Combine(rootPath, "auraFolder");
                    string fileName = "";
                    if (RequestType == "1") fileName = DirectoryPath + "\\" + new RandomGenerator().RandomGuid() + "-new-assignment.txt";
                    else if (RequestType == "2") fileName = DirectoryPath + "\\" + new RandomGenerator().RandomGuid() + "-note-update.txt";
                    if (!new GeneralService().IsCreateTextFile(aurastring, DirectoryPath, fileName)) return false;
                    return true;
                }
                return false;
            }
            catch (Exception err)
            {
                return false;
            }
        }
    }
}
