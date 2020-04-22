using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.Encode(new Video());
        }
    }
}
