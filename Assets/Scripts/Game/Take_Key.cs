using System.Collections;
using UnityEngine;

public class Take_Key : MonoBehaviour
{
    [SerializeField] private AudioSource key_audio => GetComponent<AudioSource>();

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            key_audio.enabled = true;
            StartCoroutine("take_key");
        }
    }

    IEnumerator take_key() {
        yield return new WaitForSeconds(0.5f);
        Player.key += 1;
        Destroy(gameObject);
    }
}