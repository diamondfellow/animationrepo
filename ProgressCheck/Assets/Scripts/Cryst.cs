using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Cryst : MonoBehaviour
{
    public static int crys = 0;
    
    
     void OnCollisionEnter2D(Collision2D collision)
    {
     if(collision.gameObject.tag == "Crys")
        {
            crys++;
            
            Destroy(collision.gameObject);
            if(crys == 4)
            {
               
            }
        }
     if(collision.gameObject.tag == "Win")
        {
            SceneManager.LoadScene("Win");
        }
    }
}
