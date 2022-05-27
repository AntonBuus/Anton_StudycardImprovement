using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public static DontDestroy anstance = null;
    
    private void Awake()
    {
        if (anstance == null)
        {
            anstance = this;
            DontDestroyOnLoad(base.gameObject);
        }
        else
        {
            Destroy(base.gameObject);
        }

    }
}
