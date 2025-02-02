using UnityEngine;
using UnityEngine.UI;

public class ui_fps : MonoBehaviour
{
    [SerializeField] private float fps;
    [SerializeField] private Text fps_text;

    private void Update() {
        check_fps();
    }

    private void check_fps() {
        fps = 1f / Time.deltaTime;
        fps_text.text = "fps: " + (int) fps;
    }
}