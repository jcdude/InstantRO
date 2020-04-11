using System;
using System.Collections.Generic;
using System.Text;

namespace IRO.Application.Notifications.Models
{
    /* This will be used for any type of notification that the notification service sends out.
     * Can be used to email/slack/text etc 
     */
    public class MessageDto
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
