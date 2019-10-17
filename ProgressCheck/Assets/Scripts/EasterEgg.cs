using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EasterEgg : MonoBehaviour
{
    bool eastereggstart = false;
    float timer = 0f;
    public Color a;
    public Color b;
    public Color c;
    public Color d;
    public Color e;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TrophyHealth.trophy == 0)
        {
            eastereggstart = true;
        }
        if(eastereggstart == true)
        {
            timer += Time.deltaTime;
            if (timer > 5 && timer < 5.5)
            {
                GetComponent<Image>().color = a;
            }
            else if(timer > 5.5 && timer < 6)
            {
                GetComponent<Image>().color = b;
            }
            else if (timer > 6 && timer < 6.5)
            {
                GetComponent<Image>().color = c;
            }
            else if (timer > 6.5 && timer < 7)
            {
                GetComponent<Image>().color = d;
            }
            else if (timer > 7 && timer < 7.5)
            {
                GetComponent<Image>().color = e;
            }
            else if(timer > 9)
            {
                SceneManager.LoadScene("EasterEgg");
            }
        }
    }
}
