using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Potion : MonoBehaviour
{
    [SerializeField] private GameObject player_1;
    [SerializeField] private Vector3 player_1_vector;
    [SerializeField] private GameObject player_2;
    [SerializeField] private Vector3 player_2_vector;
    [SerializeField] private bool can_take_potion = true;
    [SerializeField] private Animator potion_animator => GetComponent<Animator>();
    [SerializeField] private GameObject effects;

    void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Potion") && other.CompareTag("Player") && can_take_potion) {
            can_take_potion = false;
            StartCoroutine("take_potion");
        }
    }

    IEnumerator take_potion() {
        potion_animator.enabled = true;
        Player.can_move = false;
        effects.SetActive(true);

        yield return new WaitForSeconds(1f);
        player_1 = skins_game.player_1_main;
        player_1_vector = player_1.transform.position;
        player_2 = skins_game.player_2_main;
        player_2_vector = player_2.transform.position;
        player_1.transform.position = player_2_vector;
        player_2.transform.position = player_1_vector;

        yield return new WaitForSeconds(0.15f);
        Player.can_move = true;
        Destroy(gameObject);
    }
}