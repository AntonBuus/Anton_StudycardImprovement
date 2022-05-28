using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour : MonoBehaviour
{
    SpriteRenderer colorReader;
 
    void Start()
    {
        colorReader = GetComponent<SpriteRenderer>();
        colorReader.color = Color.HSVToRGB(0.4f, 1, 1);
    }

    private void Update()
    {
        float GyroOutput = GetComponent<GyroData>().GetGyro();
        GyroOutput = Mathf.Abs(GyroOutput);

            colorReader.color = Color.HSVToRGB(GyroOutput % 1 + 0.2f, 0.85f, 0.7f); 
    }
}
