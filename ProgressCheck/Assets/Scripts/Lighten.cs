using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lighten : MonoBehaviour
{
    public Color color1;
    public Color color2;
    public Color color3;
    public Color color4;
    public Color color5;
    float timer = 0;
    public bool timerreset = true;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
        if (EasterEggOpen.darken == true)
        {
            if(timerreset)
            {
                timer = 0f;
                timerreset = false;

            }
            
            if (timer > .5 && timer < .6)
            {
                GetComponent<Image>().color = color1;
                Debug.Log("Hello");
            }
            else if (timer > 1 && timer < 1.4)
            {
                GetComponent<Image>().color = color2;
            }
            else if (timer > 1.5 && timer < 1.9)
            {
                GetComponent<Image>().color = color3;
            }
            else if (timer > 2 && timer < 2.4)
            {
                GetComponent<Image>().color = color4;
            }
            else if (timer > 2.5 && timer < 2.6)
            {
                GetComponent<Image>().color = color5;
                EasterEggOpen.off = true;
                EasterEggOpen.darken = false;
            }
        }
    }
}
