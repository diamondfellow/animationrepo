using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barri : MonoBehaviour
{
    private static int door;

    // Update is called once per frame
    void Update()
    {
        door = Cryst.crys;
        if(door == 4)
        {
            Destroy(gameObject);
        }
    }
}
