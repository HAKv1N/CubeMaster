using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class camera_move : MonoBehaviour
{
    [SerializeField] private GameObject camera_main;
    [SerializeField] public static float camera_speed;
    [SerializeField] private Vector3 camera_main_vector;
    [SerializeField] private Vector3 start_vector;
    [SerializeField] private GameObject start_object;
    [SerializeField] private float camera_x;
    [SerializeField] private float camera_z;
    [SerializeField] private float fov = 60f;
    [SerializeField] public static bool camera_can_move = true;
    [SerializeField] private Toggle on_off_camera_move_toggle;
    [SerializeField] private Slider player_input_sensitivity;
    [SerializeField] public static float player_sensitivity = 1;

    private void Start() {
        on_off_camera_move_toggle.isOn = camera_can_move;
        player_input_sensitivity.value = player_sensitivity;
    }

    private void Update() {
        check_camera_move();
        player_sensitivity = player_input_sensitivity.value;
        camera_speed = 500 * player_sensitivity;

        if (camera_can_move && Input.GetKey(KeyCode.Mouse1)) {
            movement_camera();
        }
    }

    private void movement_camera() {
        float x = Input.GetAxis("Mouse X") * camera_speed;
        float z = Input.GetAxis("Mouse Y") * camera_speed;

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

    private void check_camera_move() {
        if (on_off_camera_move_toggle.isOn) {
            camera_can_move = true;
        }

        else if (!on_off_camera_move_toggle.isOn) {
            camera_can_move = false;
        }
    }
}