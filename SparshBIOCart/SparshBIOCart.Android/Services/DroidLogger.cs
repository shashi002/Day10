using Android.Util;
using SparshBIOCart.Services;
using System;

namespace SparshBIOCart.Droid.Services
{
    public class DroidLogger : ILogger
    {
        private const string APP_NAME = "SparshBIOCart";

        public void Error(string message)
        {
            Log.Error(APP_NAME, message);
        }

        public void Error(string format, params object[] args)
        {
            Log.Error(APP_NAME, format, args);
        }

        public void Error(Exception ex, string message)
        {
            Log.Error(APP_NAME, message);
            Log.Error(APP_NAME, ex.ToString());
        }

        public void Error(Exception ex, string format, params object[] args)
        {
            Log.Error(APP_NAME, format, args);
            Log.Error(APP_NAME, ex.ToString());
        }

        public void Info(string message)
        {
            Log.Info(APP_NAME, message);
        }

        public void Info(string format, params object[] args)
        {
            Log.Info(APP_NAME, format, args);
        }

        public void Info(Exception ex, string message)
        {
            Log.Info(APP_NAME, message);
            Log.Info(APP_NAME, ex.ToString());
        }

        public void Info(Exception ex, string format, params object[] args)
        {
            Log.Info(APP_NAME, format, args);
            Log.Info(APP_NAME, ex.ToString());
        }
    }
}