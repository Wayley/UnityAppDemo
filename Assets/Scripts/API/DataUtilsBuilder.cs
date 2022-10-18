using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataUtilsBuilder
{
    DataUtils DataUtils = null;
    DataUtils createUtils()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            return new AndroidDataUtils();
        }
        return DataUtils;
    }
}
public class AndroidDataUtils : MonoBehaviour, DataUtils
{
    static AndroidJavaObject _ajc;

    void Awake()
    {
        _ajc = new AndroidJavaObject("com.mobiledrivetech.smartclock.Utils");
    }


    public string GetWifiName()
    {
        return "MY_WIFI_NAME";
    }
    public bool GetWifiStatus()
    {
        return true;

    }
}