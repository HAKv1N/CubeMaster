using System.Collections;
using UnityEngine;

public class camera_move : MonoBehaviour
{
    [SerializeField] private GameObject camera_main;
    [SerializeField] private float camera_speed = 75f;
    [SerializeField] private Vector3 camera_main_vector;
    [SerializeField] private Vector3 start_vector;
    [SerializeField] private GameObject start_object;
    [SerializeField] private float camera_x;
    [SerializeField] private float camera_z;
    [SerializeField] private float fov = 60f;
    [SerializeField] public static bool camera_can_move = true;

    private void Update() {
        if (camera_can_move && Input.GetKey(KeyCode.Mouse1)) {
            movement_camera();
        }
    }

    private void movement_camera() {
        float x = Input.GetAxis("Mouse X");
        float z = Input.GetAxis("Mouse Y");

        start_vector = start_object.transform.position;
        camera_main_vector = new Vector3(-z, 0, x);

        camera_main.transform.RotateAround(start_vector, camera_main_vector, camera_speed * Time.deltaTime);

        float scroll = Input.GetAxis("Mouse ScrollWheel");

        if (scroll > 0f) {
            fov -= 5f;
            fov = Mathf.Clamp(fov, 45, 60);
            camera_main.GetComponent<Camera>().fieldOfView = fov;
            return;
        }

        else if (scroll < 0f) {
            fov += 5f;
            fov = Mathf.Clamp(fov, 45, 60);
            camera_main.GetComponent<Camera>().fieldOfView = fov;
            return;
        }
    }
}