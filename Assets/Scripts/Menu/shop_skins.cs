using UnityEngine;

public class shop_skins : MonoBehaviour
{
    [SerializeField] private GameObject skins_panel;
    [SerializeField] public static int skin_id = 0;
    [SerializeField] public static float money = 100f;

    public void open_skins_buy() {
        skins_panel.SetActive(true);
    }

    public void buy_skin_1() {
        if (money >= 100f) {
            skin_id = 1;
            money -= 100f;
        }
    }
}