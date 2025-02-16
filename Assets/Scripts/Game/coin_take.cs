using System.Collections;
using UnityEngine;

public class coin_take : MonoBehaviour
{
    [SerializeField] private Animator coin_animator;
    [SerializeField] private bool coin_take_can = true;
    [SerializeField] private GameObject effects;

    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Coin") && other.CompareTag("Player") && coin_take_can) {
            coin_take_can = false;
            coin_animator = GetComponent<Animator>();
            StartCoroutine(coin_anim());
        }
    }

    IEnumerator coin_anim() {
        effects.SetActive(true);
        coin_animator.enabled = true;
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
        shop_skins.money += 20f;
    }
}