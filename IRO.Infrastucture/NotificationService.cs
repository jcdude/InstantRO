using IRO.Application.Common.Interfaces;
using IRO.Application.Notifications.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IRO.Infrastucture
{
    public class NotificationService : INotificationService
    {
        public Task SendAsync(MessageDto message)
        {
            //TODO Add some type of communication gateway in here for default communications
            return Task.CompletedTask;
        }
    }
}
