using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour : MonoBehaviour
{
    SpriteRenderer sandwich;
 
    void Start()
    {
        sandwich = GetComponent<SpriteRenderer>();
        sandwich.color = Color.HSVToRGB(0.4f, 1, 1);
    }

    private void Update()
    {
        float Gyromums = GetComponent<GyroData>().GetGyro();
        Gyromums = Mathf.Abs(Gyromums);

            sandwich.color = Color.HSVToRGB(Gyromums % 1 + 0.2f, 0.85f, 0.7f); 
    }
}
