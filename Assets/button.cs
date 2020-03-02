using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using Vuforia;

public class button : MonoBehaviour, IVirtualButtonEventHandler
{

    GameObject zombie;
    /// <summary>
    /// Called when the scene is loaded
    /// </summary>
    void Start()
    {

        zombie = GameObject.Find("zombie");

        GameObject virtualButtonObject = GameObject.Find("actionButton");
        virtualButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);


    }

    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {

        Debug.Log("button Pressed");
        zombie.GetComponent<Animation>().Play();

    }

    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {

        zombie.GetComponent<Animation>().Stop();


    }
}