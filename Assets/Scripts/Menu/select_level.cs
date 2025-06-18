using System.Collections;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class select_level : MonoBehaviour
{
    [SerializeField] public static bool[] lvls_complete = new bool[61];
    [SerializeField] private int lvl_id;
    [SerializeField] private GameObject blackout_fon;
    [SerializeField] private Animator blackout_fon_animator;
    
    private void Update() {
        check_lvl_complete();
        update_text();
    }

    public void RunLevel()
    {
        StartCoroutine("start_game_button");
    }

    IEnumerator start_game_button() {
        blackout_fon.SetActive(true);
        blackout_fon_animator.SetBool("start_game", true);
        yield return new WaitForSeconds(1.5f);
        try {
            SceneManager.LoadScene(lvl_id);
        } catch {
            SceneManager.LoadScene("menu");
        }
    }

    private void check_lvl_complete() {
        if (!lvls_complete[lvl_id]) {
            gameObject.GetComponent<Image>().color = new Color(1f, 0.5f, 0.5f);
        }

        else {
            gameObject.GetComponent<Image>().color = new Color(0.5f, 1f, 0.5f);
        }
    }

    private void update_text() {
        GameObject text_lvl = gameObject.transform.Find("lvl_text(text)").gameObject;

        text_lvl.GetComponent<Text>().text = "Уровень " + lvl_id;
    }
}