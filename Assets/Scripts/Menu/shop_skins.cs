using UnityEngine;

public class shop_skins : MonoBehaviour
{
    [SerializeField] private GameObject skins_panel;
    [SerializeField] public static int item_1 = 1;

    public void open_skins_buy() {
        skins_panel.SetActive(true);
    }

    public void buy_skin() {
        item_1 = 1;
    }
}