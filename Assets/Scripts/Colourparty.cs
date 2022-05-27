using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colourparty : MonoBehaviour
{

    SpriteRenderer renderer;
    float guf = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

        renderer = GetComponent<SpriteRenderer>();
        renderer.color = Color.HSVToRGB(0.4f, 1, 1);



    }

    // Update is called once per frame
    void Update()
    {


        renderer.color = Color.HSVToRGB(guf++ % 1, 1, 1);


    }
}
