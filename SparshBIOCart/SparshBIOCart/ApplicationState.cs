
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
public class ApplicationState
{

    private static Dictionary<string, object> appStateValues = new Dictionary<string, object>();
    public static void SetValue(string key, object value)
    {
        if ((appStateValues.ContainsKey(key)))
        {
            appStateValues.Remove(key);
        }
        appStateValues.Add(key, System.Convert.ToString( value));
    }

    public static T GetValue<T>(string key)
    {
        object o ="0";
        if (appStateValues.ContainsKey(key))
        {
            o = appStateValues.ContainsKey(key);
            if (o != null)
            {
                return (T)appStateValues[key];
            }
        }

        return (T)o;
    }
}

