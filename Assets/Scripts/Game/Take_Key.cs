using UnityEngine;

public class Take_Key : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            Destroy(gameObject);
            Player.key += 1;
        }
    }
}