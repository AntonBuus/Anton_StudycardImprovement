using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyPopup : MonoBehaviour
{
    public static DontDestroyPopup nstance = null;
    private void Awake()
    {
        if (nstance == null)
        {
            nstance = this;
            DontDestroyOnLoad(base.gameObject);
        }
        else 
        { 
            Destroy(base.gameObject);
        }

    }
}
