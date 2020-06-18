using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using System.Net.Mail;
using System.Net;
namespace SportsStore.Domain.Concrete
{
   public class EmailSetting
    {
        public string MailToAddress = "Orders@example.com";
        public string mailFromAddress = "sportsstore@example.com";
        public bool Usessl = true;
        public string Username = "MySmptUsername";
        public string Password = "MySmptPassword";
        public string Servername = "smtp.example.com";
        public int ServerPort = 587;
        public bool WriteAsFile = false;
        public string FileLocation = @"C:\SportsStore";
    }
    public class EmailOrderProcessor : IorderProcessor
    {
        private EmailSetting _emailSetting;
        //public void EmailOrderProcessor(Cart cart, ShippingDetails shippingDeatils)
        //{
        //    throw new NotImplementedException(ema);
        //}
        public EmailOrderProcessor(EmailSetting Setting)
        {

            _emailSetting = Setting;
        }
        void IorderProcessor.EmailOrderProcessor(Cart cart, ShippingDetails shippingDeatils)
        {
            using (var smptClient = new SmtpClient())
            {
                smptClient.EnableSsl = _emailSetting.Usessl;
                smptClient.Host = _emailSetting.Servername;
                smptClient.Port = _emailSetting.ServerPort;
                smptClient.UseDefaultCredentials = false;
                smptClient.Credentials = new NetworkCredential(_emailSetting.Username,_emailSetting.Password);

                if (_emailSetting.WriteAsFile)
                {

                    smptClient.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                    smptClient.PickupDirectoryLocation = _emailSetting.FileLocation;
                    smptClient.EnableSsl = false;
                }
                StringBuilder body = new StringBuilder()
                            .AppendLine("A new order has been submitted").AppendLine("---").AppendLine("Items:");
                foreach(var line in cart.Lines)
                {

                    var subtotal = line.Product.Price * line.Quantity;
                    body.AppendFormat("{0} {1} (2 }",line.Quantity,line.Product.Name,subtotal);
                }

               // this is done up to here 
            //    body.AppendFormat("Total order value: {0:c}")


            }
        }
    }
}
