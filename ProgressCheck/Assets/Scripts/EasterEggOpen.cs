using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EasterEggOpen : MonoBehaviour
{
    float timer = 0f;
    public Text Message;
    public Text please;
    public static bool darken = false;
    public static bool off = false;
    
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(off)
        {
            GetComponent<Canvas>().enabled = false;
        }
        if(timer > 4 && timer < 4.5)
        {
            Message.text = "Why did you leave?";
        }
        else if(timer > 8 && timer < 8.5 )
        {
            Message.text = "What have you done?";
        }
        else if(timer > 13 && timer < 13.5)
        {
            Message.text = "Don't go too far";
            please.text = "Please...";
        }
        else if(timer > 18 && timer < 18.5)
        {
            Message.text = "";
            please.text = "";
            darken = true;
        }
    }
}
