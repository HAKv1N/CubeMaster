using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using YG;

public class game_ui : MonoBehaviour
{
    [SerializeField] private GameObject esc_menu_panel;
    [SerializeField] private float fps;
    [SerializeField] private static bool can_check_fps = true; 
    [SerializeField] private Text fps_text;
    [SerializeField] private float timer_fps = 1f;
    [SerializeField] private Text money_text;
    [SerializeField] private AudioSource audiosource => GetComponent<AudioSource>();
    [SerializeField] private float timer_for_drop_coin = 25f;
    [SerializeField] private GameObject coin_drop;
    [SerializeField] private Vector3 coin_drop_vector;
    [SerializeField] private GameObject blackout_fon;
    [SerializeField] private Animator blackout_fon_animator;
    [SerializeField] private Text lvl_text;
    [SerializeField] private Toggle on_off_fps_toggle;
    [SerializeField] public static int coin_drop_add = 25;
    [SerializeField] private Text x_text;
    [SerializeField] private float timer_for_ad = 90f;

    private void Start()
    {
        check_lvl();
        on_off_fps_toggle.isOn = can_check_fps;
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
        on_off_fps();
        check_keys();
        // show_ad_on_timer();

        money_text.text = "Денег: " + shop.money;
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
        }

        else if (Input.GetKeyDown(KeyCode.Escape) && esc_menu_panel.activeSelf)
        {
            esc_menu_panel.SetActive(false);
        }
    }

    private void check_fps()
    {
        if (can_check_fps) {
            fps_text.gameObject.SetActive(true);
            timer_fps -= 1 * Time.deltaTime;
            if (timer_fps <= 0) {
                fps = 1f / Time.deltaTime;
                fps_text.text = "fps: " + (int) fps;
                timer_fps = 1f;
            }
        }

        else fps_text.gameObject.SetActive(false);
    }

    private void drop_coins()
    {
        timer_for_drop_coin -= 1 * Time.deltaTime;
        if ((int)timer_for_drop_coin == 0)
        {
            coin_drop_vector = new Vector3(Random.Range(0, 800), Random.Range(0, 400), 0);
            coin_drop.transform.position = coin_drop_vector;
            coin_drop.SetActive(true);
            timer_for_drop_coin = 30f;
        }
    }

    public void get_drop_coin()
    {
        StartCoroutine("get_coin");
    }

    IEnumerator get_coin() {
        coin_drop.GetComponent<AudioSource>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        timer_for_drop_coin = 25f;
        coin_drop.SetActive(false);
        shop.money += coin_drop_add;
    }

    private void check_lvl() {
        lvl_text.text = "Уровень: " + SceneManager.GetActiveScene().buildIndex;
    }

    private void on_off_fps() {
        can_check_fps = on_off_fps_toggle.isOn;
    }

    private void check_keys() {
        x_text.text = "x" + Player.key;
    }

    // private void show_ad_on_timer() {
    //     timer_for_ad -= 1 * Time.deltaTime;

    //     if (timer_for_ad <= 0) {
    //         YandexGame.FullscreenShow();
    //         timer_for_ad = 90f;
    //     }
    // }
}