using System;
using UnityEngine;
using UnityEngine.UI;

public class shop_skins : MonoBehaviour
{
    [SerializeField] private GameObject skins_panel;
    [SerializeField] public static int skin_id = 0;
    [SerializeField] public static float money = 1000f;
    [SerializeField] public static bool[] skins_buy = new bool[2];
    [SerializeField] private Sprite cross_icon;
    [SerializeField] private Sprite tick_icon;
    [SerializeField] private Image[] buy_success_image = new Image[2];
    [SerializeField] private GameObject[] frames_buy = new GameObject[2];

    private void Start() {
        check_buy();
    }

    public void open_skins_buy() {
        skins_panel.SetActive(true);
    }

    private void check_buy() {
        if (skins_buy[0]) {
            buy_success_image[0].sprite = tick_icon;
        }

        if (skins_buy[1]) {
            buy_success_image[1].sprite = tick_icon;
        }

        frames_buy[skin_id - 1].SetActive(true);
    }

    //skin_1
    public void buy_skin_1() {
        if (money >= 100f) {
            if (!skins_buy[0]) {
                skins_buy[0] = true;
                money -= 100f;
                buy_success_image[0].sprite = tick_icon;
            }
        }
    }

    public void skin_1_set() {
        if (skins_buy[0]) {
            skin_id = 1;
            for (int i = 0; i < frames_buy.Length; i++) {
                frames_buy[i].SetActive(false);
            }
            frames_buy[0].SetActive(true);
        }
    }

    //skin_2
    public void buy_skin_2() {
        if (money >= 100f) {
            if (!skins_buy[1]) {
                skins_buy[1] = true;
                money -= 100f;
                buy_success_image[1].sprite = tick_icon;
            }
        }
    }

    public void skin_2_set() {
        if (skins_buy[1]) {
            skin_id = 2;
            for (int i = 0; i < frames_buy.Length; i++) {
                frames_buy[i].SetActive(false);
            }
            frames_buy[1].SetActive(true);
        }
    }
}