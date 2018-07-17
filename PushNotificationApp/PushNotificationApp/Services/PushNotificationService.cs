using System;
using System.Collections.Generic;
using System.Linq;
using FCM.Net;


namespace PushNotificationApp.Services
{
    public static class PushNotificationService
    {
        public const string serverKey = "AAAAJJ0zPT4:APA91bHBvX_booS8XcF2E6JsUhJmVVqvNg3H_-zeRHy71Zl51Hdl3_wvyxk_5OqHFpMMJB2IB6I1DfSpTZDCUixNENp1DCtmBtFlSDiyoJiOTeFCnDP42EV9_kLfkmOTMFHAGnwUEBipyGW6tcMXx2oBW3mMb_8Zzg";

        public static async void SendMessage(string title, string text)
        {
            using (var sender = new Sender(serverKey))
            {
                var message = new Message
                {
                    Data = new
                    {
                        title = "PushNotification",
                        message = text,                        
                        id = new Random().Next(1, 9000000)
                    },
                    RestrictedPackageName = "com.pushnotificationapp.android"
                };

                var result = await sender.SendAsync(message);
            }
        }        
    }
}