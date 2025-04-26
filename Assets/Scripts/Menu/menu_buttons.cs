using System.Collections;
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
    [SerializeField] private GameObject blackout_fon;
    [SerializeField] private Animator blackout_fon_animator;
    [SerializeField] private GameObject level_choose_panel;

    private void Start() {
        ui_interface.SetActive(true);
        Time.timeScale = 1;
        StartCoroutine("blackout_fon_start_menu");
    }

    IEnumerator blackout_fon_start_menu() {
        blackout_fon.SetActive(true);
        blackout_fon_animator.SetBool("start_game", false);
        yield return new WaitForSeconds(1.5f);
        blackout_fon.SetActive(false);
    }

    private void Update() {
        moneys_text.text = "Денег: " + (int) shop_skins.money;
    }

    public void start_game() {
        level_choose_panel.SetActive(!level_choose_panel.activeSelf);
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
        audio_panel.SetActive(!audio_panel.activeSelf);
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