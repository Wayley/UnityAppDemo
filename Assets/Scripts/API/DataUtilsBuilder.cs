using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataUtilsBuilder : MonoBehaviour
{
    static AndroidJavaObject _ajc;

    void Awake()
    {
        _ajc = new AndroidJavaObject("com.mobiledrivetech.settings.volume.Utils"); // ForTestAAR
    }

    public static void startActivity()
    {
        Debug.Log("start startActivity......");
        bool data = _ajc.Call<bool>("startActivity");
        Debug.Log("startActivity data: " + data);
    }
    
}
