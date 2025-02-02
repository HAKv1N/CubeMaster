using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
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
}