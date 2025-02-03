using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu_buttons : MonoBehaviour
{
    [SerializeField] private GameObject ui_interface;
    [SerializeField] private GameObject ui_settings;
    [SerializeField] private GameObject audio_panel;

    private void Start() {
        ui_interface.SetActive(true);
        Time.timeScale = 1;
    }

    public void start_game() {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }

    public void open_settings_menu() {
        ui_interface.SetActive(false);
        ui_settings.SetActive(true);
    }

    public void close_settings_menu() {
        ui_interface.SetActive(true);
        ui_settings.SetActive(false);
    }

    public void audio_settings() {
        audio_panel.SetActive(true);
    }
}