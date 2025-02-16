using UnityEngine;
using System.Collections;

public class KeyActivator : MonoBehaviour
{
    [SerializeField] private GameObject effects;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("key"))
        {
            Destroy(other.gameObject);
        }
    }


}

