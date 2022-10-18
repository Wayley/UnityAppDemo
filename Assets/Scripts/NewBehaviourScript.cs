using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start____________");

        int d = DataUtilsBuilder.GetCompassData();
        Debug.Log("----------------------------------" + d);
    }

    
    public void Test()
    {
        Debug.Log("Test____________");
        string menuStr = DataUtilsBuilder.GetMenuData();
        Debug.Log("MENU API----------------------------------" + menuStr);
    }
}
