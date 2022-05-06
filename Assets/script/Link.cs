using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Link : MonoBehaviour
{
    public VirtualButtonBehaviour vb;
    // Start is called before the first frame update
    void Start()
    {
        vb.RegisterOnButtonPressed(OnButtonPressed);
        vb.RegisterOnButtonReleased(OnButtonReleased);

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Application.OpenURL("https://www.linkedin.com/in/rahulkumar151101/");

    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }
}
