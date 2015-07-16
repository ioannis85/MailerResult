using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace MailerController
{
      class SmtpService : IDisposable
    {
        private SmtpClient client;
       
        /// <summary>
        /// Create a new Instance since Configuration Section settings
        /// </summary>
        /// <returns></returns>
         static SmtpService CreateWithConfigure()
        {
            return new SmtpService();
        }

        /// <summary>
        /// Constructor
        /// </summary>
         SmtpService()
        {
            this.client = new SmtpClient();
        }

        private static void ConfigureSmtpClient(string from, string domain, string password , uint port, bool useSsl, dynamic domainCredentials)
        {

        }


      private  void Dispose(bool disposed)
        {
            if (disposed)
            {

            }

        }

         void Dispose()
        {

            throw new NotImplementedException();
        }
    }
}
