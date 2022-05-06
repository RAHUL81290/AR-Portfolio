using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;


public class VBTN : MonoBehaviour 
{
    public Animator anime1;
    public Animator anime2;
    public Animator anime3;
    public GameObject destroy;
    public GameObject Lpuui;
    public GameObject btn;



    public VirtualButtonBehaviour vb;
    // Start is called before the first frame update
    void Start()
    {
        vb.RegisterOnButtonPressed(OnButtonPressed);
        vb.RegisterOnButtonReleased(OnButtonReleased);
    }
     void Update()

        
    {

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        anime1.SetTrigger("openanime");
        anime2.SetTrigger("open");
        anime3.SetTrigger("openproj");
        Lpuui.SetActive(true);
        Destroy(destroy);

        

    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }



}
