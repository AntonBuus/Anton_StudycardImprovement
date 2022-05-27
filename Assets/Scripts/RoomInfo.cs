using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RoomInfo : MonoBehaviour
{
    //This string determines the displayed room name
    public string roomName;

    //This string determines the displayed room type
    public string roomType;

    

    // Custom accessType
    public accessType cleareance;
    
    // Custom Text Mesh Pro Text input
    public TMP_Text textName;

    // Custom Text Mesh Pro Text input
    public TMP_Text textType;

    // Custom Text Mesh Pro Text input
    public TMP_Text textAccess;

  

    // Changes colour for the different access types
    public TMP_ColorGradient color;

    /// <summary>
    /// Three custom string values as enumaroters to assign access types of rooms: Afgang, Begr?nsetAdgang, IngenAdgang
    /// </summary>

    public enum accessType 
    {
        FreeAccess = 0,
        LimitedAccess = 1,
        NoAccess = 2
       


    }

    // The definition of data of the rooms happen in start
    public void Start()
    {
        //This string holds the information of the room access data(Which type)
        string accessText = "";

        //These if statements are looking for which access type is chosen for the room, and changes the colour accordingly
        if (cleareance == accessType.FreeAccess)
        {
            accessText = "Fri Adgang";
            textAccess.color = Color.green;
        }
        if (cleareance == accessType.LimitedAccess)
        {
            accessText = "Begrænset Adgang";
            textAccess.color = Color.yellow;

        }
        if (cleareance == accessType.NoAccess)
        {
            accessText = "Ingen adgang";
            textAccess.color = new Color(1, 0, 0);

        }

        //Displays the type of access of the room
        textAccess.text = accessText;

        //Displays the name of the room
        textName.text = "til lokale: " + roomName;

        //Displays the type of room
        textType.text = "Type af rum:" + roomType;

        
        

        
    }

}
