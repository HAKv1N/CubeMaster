using System.Collections;
using UnityEngine;

public class Emotes : MonoBehaviour
{
    [SerializeField] private bool can_use_emote = true;
    [SerializeField] private int emote_active = 0;

    private void Update() {
        use_emote();
    }

    private void use_emote() {
        if (Input.GetKeyDown(KeyCode.Alpha1) && can_use_emote) {
            emote_active = 1;
            StartCoroutine("start_emote");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2) && can_use_emote) {
            emote_active = 2;
            StartCoroutine("start_emote");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3) && can_use_emote) {
            emote_active = 3;
            StartCoroutine("start_emote");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha4) && can_use_emote) {
            emote_active = 4;
            StartCoroutine("start_emote");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha5) && can_use_emote) {
            emote_active = 5;
            StartCoroutine("start_emote");
        }
    }

    IEnumerator start_emote() {
        can_use_emote = false;
        Player.can_move = false;
        gameObject.GetComponent<Animator>().SetInteger("emote", emote_active);
        float emote_cooldown = 1.9f;
        yield return new WaitForSeconds(emote_cooldown);
        gameObject.GetComponent<Animator>().SetInteger("emote", 0);
        can_use_emote = true;
        Player.can_move = true;
    }
}