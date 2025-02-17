using System;
using UnityEngine;
using UnityEngine.UI;

public class shop_skins : MonoBehaviour
{
    [SerializeField] private GameObject skins_panel;
    [SerializeField] public static int skin_id = 0;
    [SerializeField] public static float money = 1000f;
    [SerializeField] public static bool[] skins_buy = new bool[5];
    [SerializeField] private Sprite cross_icon;
    [SerializeField] private Sprite tick_icon;
    [SerializeField] private Image[] buy_success_image = new Image[5];
    [SerializeField] private GameObject[] frames_buy = new GameObject[5];

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

        if (skins_buy[2]) {
            buy_success_image[2].sprite = tick_icon;
        }

        if (skins_buy[3]) {
            buy_success_image[3].sprite = tick_icon;
        }

        if (skins_buy[4]) {
            buy_success_image[4].sprite = tick_icon;
        }

        
        if (skin_id > 0) {
            frames_buy[skin_id - 1].SetActive(true);
        }
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
        if (money >= 200f) {
            if (!skins_buy[1]) {
                skins_buy[1] = true;
                money -= 200f;
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

    //skin_3
    public void buy_skin_3() {
        if (money >= 300f) {
            if (!skins_buy[2]) {
                skins_buy[2] = true;
                money -= 300f;
                buy_success_image[2].sprite = tick_icon;
            }
        }
    }

    public void skin_3_set() {
        if (skins_buy[2]) {
            skin_id = 3;
            for (int i = 0; i < frames_buy.Length; i++) {
                frames_buy[i].SetActive(false);
            }
            frames_buy[2].SetActive(true);
        }
    }

    //skin_4
    public void buy_skin_4() {
        if (money >= 100f) {
            if (!skins_buy[3]) {
                skins_buy[3] = true;
                money -= 100f;
                buy_success_image[3].sprite = tick_icon;
            }
        }
    }

    public void skin_4_set() {
        if (skins_buy[3]) {
            skin_id = 4;
            for (int i = 0; i < frames_buy.Length; i++) {
                frames_buy[i].SetActive(false);
            }
            frames_buy[3].SetActive(true);
        }
    }

    //skin_5
    public void buy_skin_5() {
        if (money >= 200f) {
            if (!skins_buy[4]) {
                skins_buy[4] = true;
                money -= 200f;
                buy_success_image[4].sprite = tick_icon;
            }
        }
    }

    public void skin_5_set() {
        if (skins_buy[4]) {
            skin_id = 5;
            for (int i = 0; i < frames_buy.Length; i++) {
                frames_buy[i].SetActive(false);
            }
            frames_buy[4].SetActive(true);
        }
    }
}