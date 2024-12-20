// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Linq;
using System.Drawing; // Namespace for Image class
using System.Drawing.Imaging;
using ConsoleArray;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace MyApp
{
    public class Program
    {


        public static void Main(string[] args)
        {
            var accountSid = "ACcb71a70e037b2d5afe383b336cdb37e0";
            var authToken = "67e06dba464c21f313ed863f37695cff";
            TwilioClient.Init(accountSid, authToken);

            var messageOptions = new CreateMessageOptions(
              new PhoneNumber("whatsapp:+919650445756"));
            messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
            messageOptions.Body = "Your appointment is coming up on July 21 at 3PM";


            var message = MessageResource.Create(messageOptions);
            Console.WriteLine(message.Body);

            //var accountSid = "ACcb71a70e037b2d5afe383b336cdb37e0";
            //var authToken = "67e06dba464c21f313ed863f37695cff";
            //TwilioClient.Init(accountSid, authToken);

            //var messageOptions = new CreateMessageOptions(
            //  new PhoneNumber("whatsapp:+918400460447"));
            //messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
            //messageOptions.Body = "hello Ravihguybh ub iu y hij ui";


            //var message = MessageResource.Create(messageOptions);
            Console.WriteLine(message.Body);
            //  var v = InterviewQuestion.top2mostrepetingcaharactor();
            // var n= Linq.Callmethod();

            Console.ReadLine();
            //var v =  ImageResize.ResizeImage();
            //_ = WWArray.minArray();

        }



    }
}