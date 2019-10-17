using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHP : MonoBehaviour
{
    public static int health;
    public static bool hardcore;
    public int lives;


     void Start()
    {
        if(hardcore == false)
        {
            health = 12;
        }
        else
        {
            health = 1;
        }
        lives = PlayerPrefs.GetInt("lives");


    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy"  )
        {

                                        
               health--;

            if (health < 1)
            {
                
                if(lives > 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
                else
                {
                    SceneManager.LoadScene("GameOver");
                    PlayerPrefs.SetInt("lives", lives - 1);
                }
            }

               
            
        }

    }
     void OnTriggerEnter2D(Collider2D collision1)
    {
        if(collision1.gameObject.tag == "EBullet")
        {
            health--;

            if (health < 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);


            }
        }
    }

}
