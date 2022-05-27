using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonDelete : MonoBehaviour
{
    TouchControls touchControls;
    readonly NFCNew Afc;
    
    private void Start()
    {
        touchControls = new TouchControls();
        touchControls.Enable();
        
    }

    void Update()
    // void Update bruges da den kontant skal se om den er true eller false.
    // Derefter laver vi en if-else statement, hvor en handling skal ske hver gang man trykker "Jump" eller "Space"
    {

        if (touchControls.Touch.TouchPress.IsPressed())
        {

            Afc.OnClick();
        }
    }

}
