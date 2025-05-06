using UnityEngine;

public class KeyActivator : MonoBehaviour
{
    public GameObject image_key;
    private int key = 0;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("key"))
        {
            GameObject newImage = Instantiate(image_key, new Vector3(-22.7f, -7.1f, 20.4f), Quaternion.Euler(-2.548f, -56.103f, 14.746f) );
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

