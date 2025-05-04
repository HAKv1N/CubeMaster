using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class KeyActivator : MonoBehaviour
{
    
    private int key = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("key"))
        {
            Destroy(other.gameObject);
            key += 1;
        }
    
        
    }
    private void OnCollisionEnter(Collision other)
    {
    if(key == 1){ 
        if(other.gameObject.tag == "Door")
        {
          Destroy(other.gameObject);
        }
       }
    }


}

