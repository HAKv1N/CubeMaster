using System.Collections;
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
    [SerializeField] private float timer_for_drop_coin = 25f;
    [SerializeField] private GameObject coin_drop;
    [SerializeField] private Vector3 coin_drop_vector;
    [SerializeField] private GameObject blackout_fon;
    [SerializeField] private Animator blackout_fon_animator;
    [SerializeField] private Text lvl_text;

    private void Start()
    {
        check_lvl();
        audiosource.volume = menu_ui.music_volume;
        StartCoroutine("blackout_fon_start");
    }

    IEnumerator blackout_fon_start() {
        blackout_fon.SetActive(true);
        blackout_fon_animator.SetBool("exit", false);
        yield return new WaitForSeconds(1f);
        Time.timeScale = 1f;
        blackout_fon.SetActive(false);
    }

    private void Update()
    {
        open_esc_menu();
        check_fps();
        drop_coins();

        money_text.text = "Денег: " + shop_skins.money;
    }

    public void exit_game()
    {
        StartCoroutine("blackout_fon_exit");
    }

    IEnumerator blackout_fon_exit() {
        blackout_fon.SetActive(true);
        blackout_fon_animator.SetBool("exit", true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("menu");
        Time.timeScale = 1f;
    }

    private void open_esc_menu()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !esc_menu_panel.activeSelf)
        {
            esc_menu_panel.SetActive(true);
            Time.timeScale = 1f;
        }

        else if (Input.GetKeyDown(KeyCode.Escape) && esc_menu_panel.activeSelf)
        {
            esc_menu_panel.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    private void check_fps()
    {
        fps = 1f / Time.deltaTime;
        fps_text.text = "fps: " + (int)fps;
    }

    private void drop_coins()
    {
        timer_for_drop_coin -= 1 * Time.deltaTime;
        if ((int)timer_for_drop_coin == 0)
        {
            coin_drop_vector = new Vector3(Random.Range(0, 800), Random.Range(0, 400), 0);
            coin_drop.transform.position = coin_drop_vector;
            coin_drop.SetActive(true);
            timer_for_drop_coin = 25f;
        }
    }

    public void get_drop_coin()
    {
        StartCoroutine("get_coin");
    }

    IEnumerator get_coin() {
        yield return new WaitForSeconds(0.5f);
        timer_for_drop_coin = 25f;
        coin_drop.SetActive(false);
        shop_skins.money += 50f;
    }

    private void check_lvl() {
        lvl_text.text = "Уровень: " + SceneManager.GetActiveScene().buildIndex;
    }
}
