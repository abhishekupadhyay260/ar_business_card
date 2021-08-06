using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string GmailURL;
    public string LinkedinURL;
    public string FacebookURL;   // Creating Public Strings Save URL's
    public string InstagramURL;
    // Start is called before the first frame update
    // Now I should Say Instructions.. Means Inputs...
    // Update is called once per frame
    // It's time to Paste Defined Functions in VOID UPDATE
    // Save the script And Also I will provide the script... Check the Description...
    void Update()
    {
        GMAIL();
        LINKEDIN();
        FACEBOOK();
        INSTAGRAM();
    }

    public void GMAIL()  // Creating a DEFINED Function...
    {   if (Input.GetMouseButtonDown(0)) // 0 Indicates Left Mouse Click
        { Application.OpenURL(GmailURL); } // In the brackets write sring name..
    }

    public void LINKEDIN()
    {
        if (Input.GetMouseButtonDown(0))
        { Application.OpenURL(LinkedinURL); }
    }

    public void FACEBOOK()
    {
        if (Input.GetMouseButtonDown(0))
        { Application.OpenURL(FacebookURL); }
    }

    public void INSTAGRAM()
    {
        if (Input.GetMouseButtonDown(0))
        { Application.OpenURL(InstagramURL); }
    }
}