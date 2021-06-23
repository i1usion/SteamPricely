using System;
using System.Collections.Generic;
using System.Text;

namespace SteamPricely.Interfaces
{
    public interface INotificationManager
    {
        event EventHandler NotificationReceived;
        void Initialize();
        void SendNotification(string title, string message, DateTime? notifyTime = null);
        void ReceiveNotification(string title, string message);
    }

}
