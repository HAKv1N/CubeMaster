using System;
using UnityEngine;

public class shop_skins : MonoBehaviour
{
    [SerializeField] private GameObject skins_panel;
    [SerializeField] public static int skin_id = 0;
    [SerializeField] public static float money = 1000f;
    [SerializeField] public static bool[] skins_buy = new bool[2];

    public void open_skins_buy() {
        skins_panel.SetActive(true);
    }

    //skin_1
    public void buy_skin_1() {
        if (money >= 100f) {
            if (!skins_buy[0]) {
                skins_buy[0] = true;
                money -= 100f;
            }
        }
    }

    public void skin_1_set() {
        if (skins_buy[0]) {
            skin_id = 1;
        }
    }

    //skin_2
    public void buy_skin_2() {
        if (money >= 100f) {
            if (!skins_buy[1]) {
                skins_buy[1] = true;
                money -= 100f;
            }
        }
    }

    public void skin_2_set() {
        if (skins_buy[1]) {
            skin_id = 2;
        }
    }
}