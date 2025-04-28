using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class select_level : MonoBehaviour
{
    [SerializeField] public static bool[] lvls_complete = new bool[50];
    [SerializeField] private int lvl_id;
    [SerializeField] private GameObject blackout_fon;
    [SerializeField] private Animator blackout_fon_animator;

    private void Start() {
        check_lvl_complete();
    }

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

    private void check_lvl_complete() {
        if (!lvls_complete[lvl_id]) {
            gameObject.GetComponent<Image>().color = new Color(1f, 0.5f, 0.5f);
        }

        else {
            gameObject.GetComponent<Image>().color = new Color(0.5f, 1f, 0.5f);
        }
    }
}