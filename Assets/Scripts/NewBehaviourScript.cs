using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start=========");
        DataUtilsBuilder.startActivity();
    }


    public void Test()
    {
        Debug.Log("Test=========");
        DataUtilsBuilder.startActivity();
    }
}
