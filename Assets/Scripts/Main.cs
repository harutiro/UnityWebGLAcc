using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Main : MonoBehaviour
{

    public Text text;
    
    void Start()
    {
        if(Accelerometer.current != null) InputSystem.EnableDevice(Accelerometer.current);
    }
    // Update is called once per frame
    void Update()
    {
        if (Accelerometer.current != null)
        {
            text.text = "Attitude: " + Accelerometer.current.acceleration.ReadValue().ToString();   
            transform.position = Accelerometer.current.acceleration.ReadValue();
        }
        else
        {
            text.text = "Attitude: No Attitude Sensor";
        }
        
    }
}
