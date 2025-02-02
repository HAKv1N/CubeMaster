using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_buttons : MonoBehaviour
{
    [SerializeField] private GameObject ui_interface;
    [SerializeField] private GameObject ui_settings;

    private void Start() {
        ui_interface.SetActive(true);
        Time.timeScale = 1;
    }

    public void start_game() {
        SceneManager.LoadScene(1);
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
}