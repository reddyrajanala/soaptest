using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml;

namespace SoapRequestTest
{
    public class SoapHelper
    {

        public string GetRate()
        {
            var url = ConfigurationManager.AppSettings["soapUrl"]; //https://esbqa.firsthorizon.com:17000/
            var action = ConfigurationManager.AppSettings["action"]; //ws/AcctInformation1.8
            var clientAppName = ConfigurationManager.AppSettings["soapUrl"]; 
            var clientAppUserName = ConfigurationManager.AppSettings["action"];

            var xml = GetSoapRequestXML(clientAppName, clientAppUserName);

            var soapResult = SOAPRequest(url, action, xml);

            var rate = Parse(soapResult);

            return rate;
        }

        private string Parse(string soapResult)
        {

            return "";
        }

        static AcctIntRateDataGetRs Deserialize()
        {
            // Declare the hashtable reference.
            AccountInformationResponseEnvelope responseEnvelope = null;

            // Open the file containing the data that you want to deserialize.
            FileStream fs = new FileStream("DataFile.soap", FileMode.Open);
            try
            {
                SoapFormatter formatter = new SoapFormatter();

                // Deserialize the hashtable from the file and 
                // assign the reference to the local variable.
                responseEnvelope = (AccountInformationResponseEnvelope)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

            if (responseEnvelope == null)
            {
                Console.WriteLine("unable to parse response");
            }

            return responseEnvelope.Body.AcctIntRateDataGetRs;
        }

        private string GetSoapRequestXML(string clientAppName, string clientAppUserName)
        {
            return $@"
                <soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:ns=""http://www.fhnc.com/emm/1"">
                <soapenv:Header/>
                    <soapenv:Body>
                        <ns:AcctIntRateDataGetRq>
                        <ns:RqUID>00000000-0000-0000-0000-000000000000</ns:RqUID>
                        <ns:MsgRqHdr>
                        <ns:ContextRqHdr>
                            <ns:ClientApp>
                                <ns:Name>{clientAppName}</ns:Name>
                                <ns:UserName>{clientAppUserName}</ns:UserName>
                                <ns:Channel>PFM</ns:Channel>
                            </ns:ClientApp>
                        </ns:ContextRqHdr>
                        </ns:MsgRqHdr>
                        <ns:AcctSel>
                        <ns:AcctKeys>
                            <ns:AcctId>420040316820</ns:AcctId>
                            <ns:AcctType>
                                <ns:AcctTypeValue>DDA</ns:AcctTypeValue>
                            </ns:AcctType>
                            <ns:COID>170</ns:COID>
                        </ns:AcctKeys>
                        </ns:AcctSel>
                        </ns:AcctIntRateDataGetRq>
                    </soapenv:Body>
                </soapenv:Envelope>
                ";

        }


        public String SOAPRequest(string url, string action, string xml)
        {
            XmlDocument soapEnvelopeXml = CreateSoapEnvelope(xml);
            HttpWebRequest webRequest = CreateWebRequest(url, action);

            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

            string result;
            using (WebResponse response = webRequest.GetResponse())
            {
                using (StreamReader rd = new StreamReader(response.GetResponseStream()))
                {
                    result = rd.ReadToEnd();
                }
            }
            return result;
        }

        private static HttpWebRequest CreateWebRequest(string url, string action)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Headers.Add("SOAPAction", action);
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        private static XmlDocument CreateSoapEnvelope(string xml)
        {
            XmlDocument soapEnvelopeDocument = new XmlDocument();
            soapEnvelopeDocument.LoadXml(xml);
            return soapEnvelopeDocument;
        }

        private static void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }
    }
}