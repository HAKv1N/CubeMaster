using System;
using UnityEngine;

public class shop_skins : MonoBehaviour
{
    [SerializeField] private GameObject skins_panel;
    [SerializeField] public static int skin_id = 0;
    [SerializeField] public static float money = 100f;
    [SerializeField] public static bool skin_1_buy = false;

    public void open_skins_buy() {
        skins_panel.SetActive(true);
    }

    public void buy_skin_1() {
        if (money >= 100f) {
            skin_1_buy = true;
            money -= 100f;
        }
    }

    public void skin_1_set() {
        if (skin_1_buy) {
            skin_id = 1;
        }
    }
}