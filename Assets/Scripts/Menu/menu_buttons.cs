using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu_buttons : MonoBehaviour
{
    [SerializeField] private GameObject ui_interface;
    [SerializeField] private GameObject ui_settings;
    [SerializeField] private GameObject ui_shop;
    [SerializeField] private GameObject audio_panel;
    [SerializeField] private Text moneys_text;

    private void Start() {
        ui_interface.SetActive(true);
        Time.timeScale = 1;
    }

    private void Update() {
        moneys_text.text = "Денег: " + (int) shop_skins.money;
    }

    public void start_game() {
        SceneManager.LoadScene("lvl1");
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

    public void open_shop() {
        ui_interface.SetActive(false);
        ui_shop.SetActive(true);
    }

    public void close_shop() {
        ui_interface.SetActive(true);
        ui_shop.SetActive(false);
    }
}