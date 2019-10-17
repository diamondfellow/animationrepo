using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxePickup : MonoBehaviour
{
    public bool axeinventory = false;
    public GameObject axe;
     void OnTriggerStay2D(Collider2D collision)
    {
      if(collision.gameObject.tag == "axe" && Input.GetKeyDown(KeyCode.E) && axeinventory == false)
      {
            Destroy(collision.gameObject);
            axeinventory = true;
      }
            
    }
     void Update()
    {
        Debug.Log(axeinventory);
        if (axeinventory = true && Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(axe, transform.position, Quaternion.identity);
            axeinventory = false;
        }

    }
}
