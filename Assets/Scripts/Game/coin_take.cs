using System.Collections;
using UnityEngine;

public class coin_take : MonoBehaviour
{
    [SerializeField] private Animator coin_animator;
    [SerializeField] private bool coin_take_can = true;
    [SerializeField] public static int coin_add = 20;
    [SerializeField] private GameObject effects;
    [SerializeField] private AudioSource coin_audio;

    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Coin") && other.CompareTag("Player") && coin_take_can) {
            coin_take_can = false;
            coin_animator = GetComponent<Animator>();
            coin_audio = GetComponent<AudioSource>();
            StartCoroutine("coin_anim");
        }
    }

    IEnumerator coin_anim() {
        effects.SetActive(true);
        coin_animator.enabled = true;
        coin_audio.enabled = true;
        shop.money += coin_add;
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject.transform.parent.gameObject);
    }
}