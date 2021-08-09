using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    private bool isCalledHelicopter = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Helicopter")&& !isCalledHelicopter)
        {
            isCalledHelicopter = true;
            Debug.Log("HelicopterIscalled");
        }
    }
}
