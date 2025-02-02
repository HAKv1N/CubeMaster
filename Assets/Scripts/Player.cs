using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.UI.Image;
public class Player : MonoBehaviour
{
    [SerializeField] KeyCode keyone;
    [SerializeField] KeyCode keytwo;
    [SerializeField] Vector3 moveDirection;


    private void FixedUpdate()
    {
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