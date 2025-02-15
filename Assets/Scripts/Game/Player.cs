using System.Collections;
using System.Security;
using UnityEditor.SpeedTree.Importer;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.UI.Image;

public class Player: MonoBehaviour
{
    [SerializeField] KeyCode keyone;
    [SerializeField] KeyCode keytwo;
    [SerializeField] Vector3 moveDirection;
    [SerializeField] private Animator coin_animator;
    [SerializeField] private GameObject coin_for_delete;

    private void FixedUpdate()
    {
        Movement();
    }

    public void Movement() {
        if (Input.GetKey(keyone))
        {
            GetComponent<Rigidbody>().linearVelocity += moveDirection;
        }

        if (Input.GetKey(keytwo))
        {
            GetComponent<Rigidbody>().linearVelocity -= moveDirection;
        }

        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (CompareTag("Player") && other.CompareTag("Coin")) {
            coin_animator = other.gameObject.GetComponent<Animator>();
            coin_for_delete = other.gameObject;
            StartCoroutine(coin_anim());
        }

        if (this.CompareTag("Player") && other.CompareTag("Dead"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    IEnumerator coin_anim() {
        coin_animator.enabled = true;
        yield return new WaitForSeconds(1f);
        Destroy(coin_for_delete);
        shop_skins.money += 20f;
    }
}