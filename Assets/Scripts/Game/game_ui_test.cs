using UnityEngine;
using UnityEngine.SceneManagement;

public class game_ui_test : MonoBehaviour
{
    public void exit_game() {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}