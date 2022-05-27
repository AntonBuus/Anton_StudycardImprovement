using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpPopUp : MonoBehaviour
{
    public GameObject popuphelp;
    TouchControls touchControls;



    void Update()
    {
        if (touchControls.Touch.Click.IsPressed())
        {
            OpenPopuphelp();
           // HidePopuphelp();
        }
        // Instantiate(popuphelp, transform.position, transform.rotation);
        //  spawned = true;
    }


    public void OpenPopuphelp()
    {
        if(popuphelp != null)
        {
            bool isActive = popuphelp.activeSelf;
            popuphelp.SetActive(! isActive);
        }
    }

   /* public void HidePopuphelp()
    {
        bool isActive = true;

        if (popuphelp != isActive)
        {
            popuphelp.SetActive(false);
        }
    }*/




}









   /* // Start is called before the first frame update
    private void Start()
    {
        touchControls = new TouchControls();
        touchControls.Enable();
    }




     // Update is called once per frame
     void Update()
     {
         if (touchControls.Touch.Click.IsPressed()) ;
         Instantiate(popuphelp, transform.position, transform.rotation);
         //  spawned = true;
     }
 }

    public void Openpopuphelp()
    {
        if (popuphelp != null)
        {
            popuphelp.SetActive(True);
        }
    }
} */
