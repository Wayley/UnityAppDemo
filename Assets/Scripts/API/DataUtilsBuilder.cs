using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidDataUtils : MonoBehaviour
{
    static AndroidJavaObject _ajc;

    void Awake()
    {
        _ajc = new AndroidJavaObject("com.mobiledrivetech.smartclock.Utils");
    }

    //获取底层指南针的数据
    public static int GetCompassData()
    {
        Debug.Log("start getCompassData......");
        string data = _ajc.Call<string>("getCompass");
        Debug.Log("getCompassData, data: " + data);
        return !string.IsNullOrEmpty(data) ? int.Parse(data) : 0;
    }

    public static void setMenu(string menu)
    {
        Debug.Log("setMenu, menu: " + menu);
        _ajc.Call("setMenu", menu);
        Debug.Log("setMenu ok");
    }

    public static void setClockTheme(string theme)
    {
        Debug.Log("setClockTheme, theme: " + theme);
        _ajc.Call("setClockTheme", theme);
        Debug.Log("setClockTheme ok");
    }

}
