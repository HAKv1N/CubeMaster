using UnityEngine;
<<<<<<< HEAD:Assets/Scripts/Player.cs
using UnityEngine.SceneManagement;
using static UnityEngine.UI.Image;
=======

>>>>>>> c5520d197eabcef46637acd2aacf632e23bc0e30:Assets/Scripts/Game/Player.cs
public class Player : MonoBehaviour
{
    [SerializeField] KeyCode keyone;
    [SerializeField] KeyCode keytwo;
    [SerializeField] Vector3 moveDirection;

    private void FixedUpdate()
    {
        movement();
    }

    public void movement() {
        if (Input.GetKey(keyone))
        {
            GetComponent<Rigidbody>().linearVelocity += moveDirection;
        }

        if (Input.GetKey(keytwo))
        {
            GetComponent<Rigidbody>().linearVelocity -= moveDirection;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }
}