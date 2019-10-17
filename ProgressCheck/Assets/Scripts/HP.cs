using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    private static int hp;
   
    void Update()
    {
        hp = PlayerHP.health;
        GetComponent<Animator>().SetFloat("hp", hp);
    }
}
 