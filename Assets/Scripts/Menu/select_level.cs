using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class select_level : MonoBehaviour
{
    [SerializeField] private int lvl_id;
    [SerializeField] private GameObject blackout_fon;
    [SerializeField] private Animator blackout_fon_animator;

    public void RunLevel() {
        StartCoroutine("start_game_button");
    }

    IEnumerator start_game_button() {
        blackout_fon.SetActive(true);
        blackout_fon_animator.SetBool("start_game", true);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(lvl_id);
        Time.timeScale = 1;
    }
}