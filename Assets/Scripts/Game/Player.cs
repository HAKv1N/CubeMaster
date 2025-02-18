using System.Collections;
using System.Security;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.UI.Image;

public class Player: MonoBehaviour
{
    [SerializeField] KeyCode keyone;
    [SerializeField] KeyCode keytwo;
    [SerializeField] Vector3 moveDirection;
    [SerializeField] public static bool can_move = true;

    private void FixedUpdate()
    {
        Movement();
    }

    public void Movement() {
        if (Input.GetKey(keyone) && can_move)
        {
            GetComponent<Rigidbody>().linearVelocity += moveDirection;
        }

        if (Input.GetKey(keytwo) && can_move)
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

        if (this.CompareTag("Player") && other.CompareTag("Dead"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}