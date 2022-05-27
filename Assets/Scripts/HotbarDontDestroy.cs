using UnityEngine;

public class HotbarDontDestroy : MonoBehaviour
{
    public static HotbarDontDestroy instance = null;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(base.gameObject);
        }
        else
        {
            Destroy(base.gameObject);
        }
    }
}