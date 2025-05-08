using System.Collections;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private GameObject teleport_in;
    [SerializeField] private GameObject teleport_out;
    [SerializeField] private Vector3 teleport_out_vector;
    [SerializeField] private static bool can_teleport = true;
    [SerializeField] private GameObject effects;
    [SerializeField] private GameObject player;
    [SerializeField] private AudioSource teleport_audio => GetComponent<AudioSource>();

    void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Teleport") && other.CompareTag("Player") && can_teleport) {
            player = other.gameObject;
            StartCoroutine("teleport_on");
        }
    }

    IEnumerator teleport_on() {
        effects.SetActive(true);
        teleport_audio.enabled = true;
        teleport_audio.Play();
        teleport_out_vector = teleport_out.transform.position;
        can_teleport = false;
        Player.can_move = false;
        player.GetComponentInChildren<Animator>().SetBool("teleport_on", true);
        yield return new WaitForSeconds(1f);
        player.transform.position = teleport_out_vector;
        yield return new WaitForSeconds(1f);
        Player.can_move = true;
        player.GetComponentInChildren<Animator>().SetBool("teleport_on", false);
        yield return new WaitForSeconds(7f);
        effects.SetActive(false);
        can_teleport = true;
    }
}