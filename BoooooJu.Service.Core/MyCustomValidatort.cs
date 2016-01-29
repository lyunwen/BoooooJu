using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Security.Cryptography.X509Certificates;

namespace ServerWcfService.CustomValidators
{
    public class MyCustomValidatort : System.IdentityModel.Selectors.X509CertificateValidator
    {
        public override void Validate(X509Certificate2 certificate)
        {
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Certificate Subject is :{0}", certificate.Subject);
            //Console.WriteLine("Certificate Thumbprint is :{0}", certificate.Thumbprint);
            ////This is the Client  Certificate Thumbprint,In Production,We can validate the Certificate With CA
            //if (certificate.Thumbprint.ToLower() != "748e3f8d07f14750460244045e21633cf1f5b211")
            //{

            //    Console.WriteLine("CertificateValidatation is failed !{0}", certificate.Subject);
            //    throw new SecurityTokenException("Unknown Certificate");
            //}
            //else
            //{
            //    Console.WriteLine("CertificateValidatation is sucessfully !:{0}", certificate.Subject);
            //}
        }
    }

}