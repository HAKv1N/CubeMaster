using UnityEngine;
using UnityEngine.SceneManagement;

public class game_ui : MonoBehaviour
{
    [SerializeField] private GameObject esc_menu_panel;

    private void Update() {
        open_esc_menu();
    }

    public void exit_game() {
        SceneManager.LoadScene("menu");
        Time.timeScale = 1;
    }

    public void open_esc_menu() {
        if (Input.GetKeyDown(KeyCode.Escape) && !esc_menu_panel.activeSelf) {
            esc_menu_panel.SetActive(true);
            Time.timeScale = 0f;
        }

        else if (Input.GetKeyDown(KeyCode.Escape) && esc_menu_panel.activeSelf) {
            esc_menu_panel.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}