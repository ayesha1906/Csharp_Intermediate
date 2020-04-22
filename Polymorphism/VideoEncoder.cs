using System.Collections.Generic;

namespace Polymorphism
{
    public  class VideoEncoder
    {

        // private readonly MailService _mailService; no longer needed after creating our interface

        private readonly IList<INotificationChannel> _notificationChannel;

        public VideoEncoder()
        {
            //_mailService = new MailService(); not longer  needed
            _notificationChannel = new List<INotificationChannel>();

        }
        public void Encode(Video video)
        {
            //Video Encoding logic
            //...

            //  _mailService.Send(new Mail()); no longer needed

            /* Now when we iterate over this _notificationchannel list , at runtime when we call the Send method
             * depending on that runtime type of _notificationchannel a different method would be called.
             * That is what we call Polymorphism.
             * eg : if at rumtime we call the list which is MailNotificationChannel object then the send method of MethodNotificatioChannel will be called.
             * and if second element of list is SmsNotiChannel object then send method  of that class will be called.
             * */

            foreach (var channel in _notificationChannel)
                channel.Send(new Message());
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannel.Add(channel);
        }
    }
}
