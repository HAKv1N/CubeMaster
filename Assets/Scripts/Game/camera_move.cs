using System.Collections;
using UnityEngine;

public class camera_move : MonoBehaviour
{
    [SerializeField] private GameObject camera_main;
    [SerializeField] private float camera_speed = 15f;
    [SerializeField] private GameObject player_first;
    [SerializeField] private Vector3 player_first_vector;
    [SerializeField] private Vector3 camera_main_vector;

    private void Update() {
        movement_camera();
    }

    private void movement_camera() {
        float x = Input.GetAxis("Mouse X");
        float z = Input.GetAxis("Mouse Y");

        player_first_vector = player_first.transform.position;
        camera_main_vector = new Vector3(-z, 0, x);

        camera_main.transform.RotateAround(player_first_vector, camera_main_vector, camera_speed * Time.deltaTime);
    }
}