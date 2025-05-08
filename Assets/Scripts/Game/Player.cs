using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player: MonoBehaviour
{
    [SerializeField] KeyCode keyone;
    [SerializeField] KeyCode keytwo;
    [SerializeField] public Vector3 moveDirection = new Vector3(1, 0, 0);
    [SerializeField] public static bool can_move = true;
    [SerializeField] public static int key = 0;
    [SerializeField] private GameObject door_obj;

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
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Door") && key >= 1) {
            door_obj = collision.gameObject;
            StartCoroutine("open_door");
        }
    }

    IEnumerator open_door() {
        door_obj.GetComponent<AudioSource>().enabled = true;
        door_obj.GetComponentInChildren<Animator>().enabled = true;
            
        yield return new WaitForSeconds(1f);
        if (door_obj != null) {
            key -= 1;
            Destroy(door_obj.gameObject);
        }
    }
}