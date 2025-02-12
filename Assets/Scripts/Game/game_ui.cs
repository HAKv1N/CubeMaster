using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class game_ui : MonoBehaviour
{
    [SerializeField] private GameObject esc_menu_panel;
    [SerializeField] private float fps;
    [SerializeField] private Text fps_text;
    [SerializeField] private Text money_text;
    [SerializeField] private AudioSource audiosource => GetComponent<AudioSource>();

    private void Start() {
        audiosource.volume = menu_ui.music_volume;
    }

    private void Update() {
        open_esc_menu();
        check_fps();

        money_text.text = "Денег: " + shop_skins.money;
    }

    public void exit_game() {
        SceneManager.LoadScene("menu");
        Time.timeScale = 1;
    }

    private void open_esc_menu() {
        if (Input.GetKeyDown(KeyCode.Escape) && !esc_menu_panel.activeSelf) {
            esc_menu_panel.SetActive(true);
            Time.timeScale = 0f;
        }

        else if (Input.GetKeyDown(KeyCode.Escape) && esc_menu_panel.activeSelf) {
            esc_menu_panel.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    private void check_fps() {
        fps = 1f / Time.deltaTime;
        fps_text.text = "fps: " + (int) fps;
    }
}