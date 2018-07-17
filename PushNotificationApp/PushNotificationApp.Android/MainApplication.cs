using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Plugin.FirebasePushNotification;

namespace PushNotificationApp.Droid
{
    [Application]
    public class MainApplication : Application, Application.IActivityLifecycleCallbacks
    {
        public MainApplication(IntPtr handle, JniHandleOwnership transer) : base(handle, transer)
        {
        }

        public void OnActivityCreated(Activity activity, Bundle savedInstanceState)
        {
            
        }

        public void OnActivityDestroyed(Activity activity)
        {
            
        }

        public void OnActivityPaused(Activity activity)
        {
            
        }

        public void OnActivityResumed(Activity activity)
        {
            
        }

        public void OnActivitySaveInstanceState(Activity activity, Bundle outState)
        {
            
        }

        public void OnActivityStarted(Activity activity)
        {
            
        }

        public void OnActivityStopped(Activity activity)
        {
            
        }

        public override void OnCreate()
        {
            base.OnCreate();
            RegisterActivityLifecycleCallbacks(this);
            //If debug you should reset the token each time.
        #if DEBUG
            FirebasePushNotificationManager.Initialize(this, true);
        #else
                FirebasePushNotificationManager.Initialize(this,false);
        #endif
        
            //FirebasePushNotificationManager.NotificationActivityType = typeof(MainActivity);
            //FirebasePushNotificationManager.IconResource = Resource.Drawable.whitelogo;

            //Handle notification when app is closed here
            CrossFirebasePushNotification.Current.OnNotificationReceived += (s, p) =>
            {


            };
            //A great place to initialize Xamarin.Insights and Dependency Services!
            //Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.FontAwesomeModule());
        }

        public override void OnTerminate()
        {
            base.OnTerminate();
            UnregisterActivityLifecycleCallbacks(this);
        }
    }
}