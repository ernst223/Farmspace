using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Security;

namespace FarmboekAPI.TransUnionRepository
{
    public class TransUnionService
    {
        public string DummyTransUnionRequestHelloWorld()
        {
            //Calling CreateSOAPWebRequest method  
            HttpWebRequest request = DummyCreateSOAPWebRequest();

            XmlDocument SOAPReqBody = new XmlDocument();
            //SOAP Body Request  
            //            SOAPReqBody.LoadXml(@"<?xml version=""1.0"" encoding=""utf-8""?>
            //<soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
            //  <soap:Body>
            //    <HelloWorld xmlns=""https://secure.transunion.co.za/TUBureau""/>
            //  </soap:Body>
            //</soap:Envelope>");

            SOAPReqBody.LoadXml(@"<?xml version=""1.0"" encoding=""utf-8""?>
<soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
  <soap:Body>
    <HelloWorld xmlns=""https://secure.transunion.co.za/TUBureau"" />
  </soap:Body >
</soap:Envelope>");


            using (Stream stream = request.GetRequestStream())
            {
                SOAPReqBody.Save(stream);
            }
            //Geting response from request  
            using (WebResponse Serviceres = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(Serviceres.GetResponseStream()))
                {
                    //reading stream  
                    var ServiceResult = rd.ReadToEnd();
                    return ServiceResult;
                }
            }
        }

        public HttpWebRequest DummyCreateSOAPWebRequest()
        {
            //Making Web Request  
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(@"https://securetest.transunion.co.za/tubureau118/commercial.asmx?op=HelloWorld");
            //SOAPAction  
            //Req.Headers.Add(@"SOAPAction:https://secure.transunion.co.za/TUBureau118test/Consumer.asmx?op=HelloWorld");
            //Content_type  
            Req.ContentType = "text/xml";
            Req.Accept = "text/xml";
            //HTTP method  
            Req.Method = "POST";
            //return HttpWebRequest  
            return Req;
        }

        // Transaction 37 Commercial
        public string Transaction37Commercial()
        {
            //Calling CreateSOAPWebRequest method  
            HttpWebRequest request = Trans37CreateSOAPWebRequest();

            XmlDocument SOAPReqBody = new XmlDocument();
            //SOAP Body Request  
            //            SOAPReqBody.LoadXml(@"<?xml version=""1.0"" encoding=""utf-8""?>
            //<soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
            // <soap:Body>
            //    <ProcessRequestTrans37 xmlns=""https://secure.transunion.co.za/TUBureau"">
            //       <BureauEnquiry37>
            //        <EnquirerContactName>Ernst</EnquirerContactName>
            //        <EnquirerContactPhoneNo>0824189002</EnquirerContactPhoneNo>
            //        <EnquiryAmount>9</EnquiryAmount>
            //        <Surname>Blignaut</Surname>        
            //        <Forename1>Ernst</Forename1>
            //        <IdentityNo1>9702035123084</IdentityNo1>
            //       </BureauEnquiry37>
            //      <Destination>Test</Destination>
            //    </ProcessRequestTrans37>
            //  </soap:Body>
            //</soap:Envelope>");
            SOAPReqBody.LoadXml(@"<?xml version=""1.0"" encoding=""utf-8""?>
<soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
  <soap:Body>
    <Transaction32 xmlns=""https://secure.transunion.co.za/TUBureau"">
      <Transaction32>
        <ContactName>Ernst</ContactName>
        <ContactSurname>Blignaut</ContactSurname>
        <PhoneCode>+27</PhoneCode>
        <PhoneNo>0824189002</PhoneNo>
        <UserId>9702035123084</UserId>
        <BusinessName>DankoSpark</BusinessName>
        <RegistrationNumber>JGS288</RegistrationNumber>
        <VatNumber>123456789</VatNumber>
        <TradingName>DankoSpark</TradingName>
        <CompanyType>IT</CompanyType>
        <BranchCode>25223</BranchCode>
        <EnquiryReason>This is just a test</EnquiryReason>
        <Module>Test</Module>
        <Principals>
          <PrincipalTransaction32>
            <Surname>Blignaut</Surname>
            <Forename1>Phillipus</Forename1>
            <Initials>E.P.</Initials>
            <RSAId>9702035123084</RSAId>
            <DateOfBirth>02/03/1997</DateOfBirth>
            <Address1>Bezuidenthout Street 2</Address1>
            <Address2>Street 2</Address2>
            <Suburb>Oeversug</Suburb>
            <City>Potchefstroom</City>
            <PostCode>2522</PostCode>
            <ProvinceCode>2522</ProvinceCode>
            <Gender>Maile</Gender>
          </PrincipalTransaction32>
        </Principals>
      </Transaction32>
    </Transaction32>
  </soap:Body>
</soap:Envelope>");


            using (Stream stream = request.GetRequestStream())
            {
                SOAPReqBody.Save(stream);
            }
            //Geting response from request  
            using (WebResponse Serviceres = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(Serviceres.GetResponseStream()))
                {
                    //reading stream  
                    var ServiceResult = rd.ReadToEnd();
                    return ServiceResult;
                }
            }
        }
        public HttpWebRequest Trans37CreateSOAPWebRequestCommercial()
        {
            //Making Web Request  
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(@"https://securetest.transunion.co.za/tubureau118/commercial.asmx?op=Transaction32");
            //SOAPAction  
            //Req.Headers.Add();
            //Content_type  
            Req.ContentType = "text/xml";
            Req.Accept = "text/xml";
            //HTTP method  
            Req.Method = "POST";
            //return HttpWebRequest  
            return Req;
        }

        // Transaction 37
        public string Transaction37()
        {
            //Calling CreateSOAPWebRequest method  
            HttpWebRequest request = Trans37CreateSOAPWebRequest();

            XmlDocument SOAPReqBody = new XmlDocument();
            //SOAP Body Request  
            SOAPReqBody.LoadXml(@"<?xml version=""1.0"" encoding=""utf-8""?>
<soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
 <soap:Body>
    <ProcessRequestTrans37 xmlns=""https://secure.transunion.co.za/TUBureau"">
       <BureauEnquiry37>
        <EnquirerContactName>Ernst</EnquirerContactName>
        <EnquirerContactPhoneNo>0824189002</EnquirerContactPhoneNo>
        <EnquiryAmount>9</EnquiryAmount>
        <Surname>Blignaut</Surname>        
        <Forename1>Ernst</Forename1>
        <IdentityNo1>9702035123084</IdentityNo1>
       </BureauEnquiry37>
      <Destination>Test</Destination>
    </ProcessRequestTrans37>
  </soap:Body>
</soap:Envelope>");


            using (Stream stream = request.GetRequestStream())
            {
                SOAPReqBody.Save(stream);
            }
            //Geting response from request  
            using (WebResponse Serviceres = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(Serviceres.GetResponseStream()))
                {
                    //reading stream  
                    var ServiceResult = rd.ReadToEnd();
                    return ServiceResult;
                }
            }
        }
        public HttpWebRequest Trans37CreateSOAPWebRequest()
        {
            //Making Web Request  
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(@"https://secure.transunion.co.za/TUBureau118test/Consumer.asmx?op=ProcessRequestTrans37");
            //SOAPAction  
            //Req.Headers.Add();
            //Content_type  
            Req.ContentType = "text/xml";
            Req.Accept = "text/xml";
            //HTTP method  
            Req.Method = "POST";
            //return HttpWebRequest  
            return Req;
        }
    } 
}
