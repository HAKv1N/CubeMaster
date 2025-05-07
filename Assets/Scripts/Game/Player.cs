using System.Collections;
using System.Security;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using static UnityEngine.UI.Image;

public class Player: MonoBehaviour
{
    [SerializeField] KeyCode keyone;
    [SerializeField] KeyCode keytwo;
    [SerializeField] public Vector3 moveDirection = new Vector3(1, 0, 0);
    [SerializeField] public static bool can_move = true;
    [SerializeField] public static int key = 0;

    private void FixedUpdate() {
        Movement();
    }

    public void Movement() {
        if (Input.GetKey(keyone) && can_move) {
            GetComponent<Rigidbody>().linearVelocity += moveDirection;
        }

        if (Input.GetKey(keytwo) && can_move) {
            GetComponent<Rigidbody>().linearVelocity -= moveDirection;
        }

        if (Input.GetKey(KeyCode.R)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Player") && other.CompareTag("Finish")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (CompareTag("Player") && other.CompareTag("Dead")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Door") && key >= 1) {
            Destroy(collision.gameObject);
            key -= 1;
        }
    }
}