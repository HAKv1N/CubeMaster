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

    void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Teleport") && other.CompareTag("Player") && can_teleport) {
            player = other.gameObject;
            StartCoroutine("teleport_on");
        }
    }

    IEnumerator teleport_on() {
        effects.SetActive(true);
        teleport_out_vector = teleport_out.transform.position;
        can_teleport = false;
        Player.can_move = false;
        player.GetComponentInChildren<Animator>().SetBool("teleport_on", true);
        yield return new WaitForSeconds(1);
        player.transform.position = teleport_out_vector;
        Player.can_move = true;
        yield return new WaitForSeconds(1f);
        player.GetComponentInChildren<Animator>().SetBool("teleport_on", false);
        yield return new WaitForSeconds(7);
        effects.SetActive(false);
        can_teleport = true;
    }
}