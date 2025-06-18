 using System;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class shop : MonoBehaviour
{
    [SerializeField] private GameObject skins_panel;
    [SerializeField] private GameObject upgrades_panel;
    [SerializeField] public static int skin_id = 0;
    [SerializeField] public static float money = 0f;
    [SerializeField] public static bool[] skins_buy = new bool[12];
    [SerializeField] private Sprite cross_icon;
    [SerializeField] private Sprite tick_icon;
    [SerializeField] private Image[] buy_success_image = new Image[12];
    [SerializeField] private GameObject[] frames_buy = new GameObject[12];
    [SerializeField] public static int[] ads_viewed_for_skin = new int[4];
    [SerializeField] private Text[] ads_viewed_texts = new Text[4];
    [SerializeField] public static bool[] coin_upgrade_buy = new bool[3];
    [SerializeField] private Image[] buy_success_image_coin = new Image[3];
    [SerializeField] public static bool[] coin_drop_upgrade_buy = new bool[3];
    [SerializeField] private Image[] buy_success_image_coin_drop = new Image[3];

    private void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            ads_viewed_for_skin[i] = 3;
        }
    }
    
    private void Update() {
        check_buy_skins();
        check_buy_coin_upgrade();
        check_buy_coin_drop_upgrade();
    }

    public void open_skins_buy()
    {
        skins_panel.SetActive(!skins_panel.activeSelf);
        upgrades_panel.SetActive(false);
    }

    public void open_upgrades_buy() {
        upgrades_panel.SetActive(!upgrades_panel.activeSelf);
        skins_panel.SetActive(false);
    }

    private void check_buy_skins() {
        for (int id = 0; id < skins_buy.Length; id ++) {
            if (skins_buy[id]) {
                buy_success_image[id].sprite = tick_icon;
            }
        }

        if (skin_id > 0) {
            frames_buy[skin_id - 1].SetActive(true);
        }
    }

    //skin_1
    public void buy_skin_1() {
        if (money >= 150f) {
            if (!skins_buy[0]) {
                skins_buy[0] = true;
                money -= 150f;
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
        if (money >= 150f) {
            if (!skins_buy[1]) {
                skins_buy[1] = true;
                money -= 150f;
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
        if (money >= 300f) {
            if (!skins_buy[3]) {
                skins_buy[3] = true;
                money -= 300f;
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
        if (money >= 650f) {
            if (!skins_buy[4]) {
                skins_buy[4] = true;
                money -= 650f;
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

    //skin_6
    public void buy_skin_6() {
        if (money >= 650f) {
            if (!skins_buy[5]) {
                skins_buy[5] = true;
                money -= 650f;
                buy_success_image[5].sprite = tick_icon;
            }
        }
    }

    public void skin_6_set() {
        if (skins_buy[5]) {
            skin_id = 6;
            for (int i = 0; i < frames_buy.Length; i++) {
                frames_buy[i].SetActive(false);
            }
            frames_buy[5].SetActive(true);
        }
    }

    //skin_7
    public void buy_skin_7() {
        if (money >= 1200f) {
            if (!skins_buy[6]) {
                skins_buy[6] = true;
                money -= 1200f;
                buy_success_image[6].sprite = tick_icon;
            }
        }
    }

    public void skin_7_set() {
        if (skins_buy[6]) {
            skin_id = 7;
            for (int i = 0; i < frames_buy.Length; i++) {
                frames_buy[i].SetActive(false);
            }
            frames_buy[6].SetActive(true);
        }
    }

    //skin_8
    public void buy_skin_8() {
        if (money >= 1200f) {
            if (!skins_buy[7]) {
                skins_buy[7] = true;
                money -= 1200f;
                buy_success_image[7].sprite = tick_icon;
            }
        }
    }

    public void skin_8_set() {
        if (skins_buy[7]) {
            skin_id = 8;
            for (int i = 0; i < frames_buy.Length; i++) {
                frames_buy[i].SetActive(false);
            }
            frames_buy[7].SetActive(true);
        }
    }
    
    //REWARD FOR AD
    private void Reward(int skinNumber)
    {
        ads_viewed_for_skin[skinNumber] -= 1;
        
        // Обновляем текст
        ads_viewed_texts[skinNumber].text = (3 - ads_viewed_for_skin[skinNumber]) + "/3";
        
        // Проверяем, достигнут ли необходимый просмотров
        if (ads_viewed_for_skin[skinNumber] == 0)
        {
            int skinIndex = skinNumber + 8; // так как skin_9 соответствует индексу 8
            skins_buy[skinIndex] = true;
            buy_success_image[skinIndex].sprite = tick_icon;
        }
    }

    // Общий метод для покупки скинов через рекламу
    public void BuySkinWithAds(int skinNumber)
    {
        if (!skins_buy[skinNumber + 8] && ads_viewed_for_skin[skinNumber] > 0)
        {
            // Подписываемся на событие успешного просмотра рекламы
            YandexGame.RewardVideoEvent += OnRewardVideoShown;
            // Сохраняем номер скина для использования в callback
            lastRequestedSkin = skinNumber;
            // Показываем рекламу
            YandexGame.RewVideoShow(skinNumber);
        }
    }

    private int lastRequestedSkin = -1;

    // Callback, который вызывается после успешного просмотра рекламы
    private void OnRewardVideoShown(int id)
    {
        // Проверяем, что это наш вызов (id соответствует skinNumber)
        if (id == lastRequestedSkin)
        {
            Reward(id);
            // Отписываемся от события
            YandexGame.RewardVideoEvent -= OnRewardVideoShown;
            lastRequestedSkin = -1;
        }
    }

    //skin_9
    public void buy_skin_9() => BuySkinWithAds(0);

    public void skin_9_set() {
        if (ads_viewed_for_skin[0] == 0 && skins_buy[8]) {
            skin_id = 9;
            for (int i = 0; i < frames_buy.Length; i++) {
                frames_buy[i].SetActive(false);
            }
            frames_buy[8].SetActive(true);
        }
    }

    //skin_10
    public void buy_skin_10() => BuySkinWithAds(1);

    public void skin_10_set() {
        if (ads_viewed_for_skin[1] == 0 && skins_buy[9]) {
            skin_id = 10;
            for (int i = 0; i < frames_buy.Length; i++) {
                frames_buy[i].SetActive(false);
            }
            frames_buy[9].SetActive(true);
        }
    }

    //skin_11
    public void buy_skin_11() => BuySkinWithAds(2);

    public void skin_11_set() {
        if (ads_viewed_for_skin[2] == 0 && skins_buy[10]) {
            skin_id = 11;
            for (int i = 0; i < frames_buy.Length; i++) {
                frames_buy[i].SetActive(false);
            }
            frames_buy[10].SetActive(true);
        }
    }

    //skin_12
    public void buy_skin_12() => BuySkinWithAds(3);

    public void skin_12_set() {
        if (ads_viewed_for_skin[3] == 0 && skins_buy[11]) {
            skin_id = 11;
            for (int i = 0; i < frames_buy.Length; i++) {
                frames_buy[i].SetActive(false);
            }
            frames_buy[11].SetActive(true);
        }
    }

    
    //coin_upgrade
    private void check_buy_coin_upgrade() {
        if (coin_upgrade_buy[0]) {
            buy_success_image_coin[0].sprite = tick_icon;
        }

        if (coin_upgrade_buy[1]) {
            buy_success_image_coin[1].sprite = tick_icon;
        }

        if (coin_upgrade_buy[2]) {
            buy_success_image_coin[2].sprite = tick_icon;
        }
    }

    public void buy_coin_1() {
        if (money >= 150f && !coin_upgrade_buy[0] && !coin_upgrade_buy[1] && !coin_upgrade_buy[2]) {
            buy_success_image_coin[0].sprite = tick_icon;
            coin_upgrade_buy[0] = true;
            coin_take.coin_add = 30;
            money -= 150f;
        }
    }

    public void buy_coin_2() {
        if (money >= 400f && coin_upgrade_buy[0] && !coin_upgrade_buy[1] && !coin_upgrade_buy[2]) {
            buy_success_image_coin[1].sprite = tick_icon;
            coin_upgrade_buy[1] = true;
            coin_take.coin_add = 40;
            money -= 400f;
        }
    }

    public void buy_coin_3() {
        if (money >= 1000f && coin_upgrade_buy[0] && coin_upgrade_buy[1] && !coin_upgrade_buy[2]) {
            buy_success_image_coin[2].sprite = tick_icon;
            coin_upgrade_buy[2] = true;
            coin_take.coin_add = 50;
            money -= 1000f;
        }
    }

    //coin_drop_upgrade
    private void check_buy_coin_drop_upgrade() {
        if (coin_upgrade_buy[0]) {
            buy_success_image_coin_drop[0].sprite = tick_icon;
        }

        if (coin_upgrade_buy[1]) {
            buy_success_image_coin_drop[1].sprite = tick_icon;
        }

        if (coin_upgrade_buy[2]) {
            buy_success_image_coin_drop[2].sprite = tick_icon;
        }
    }

    public void buy_coin_drop_1() {
        if (money >= 100f && !coin_drop_upgrade_buy[0] && !coin_drop_upgrade_buy[1] && !coin_drop_upgrade_buy[2]) {
            buy_success_image_coin_drop[0].sprite = tick_icon;
            coin_drop_upgrade_buy[0] = true;
            game_ui.coin_drop_add = 40;
            money -= 100f;
        }
    }

    public void buy_coin_drop_2() {
        if (money >= 250f && coin_drop_upgrade_buy[0] && !coin_drop_upgrade_buy[1] && !coin_drop_upgrade_buy[2]) {
            buy_success_image_coin_drop[1].sprite = tick_icon;
            coin_drop_upgrade_buy[1] = true;
            game_ui.coin_drop_add = 55;
            money -= 250f;
        }
    }

    public void buy_coin_drop_3() {
        if (money >= 700f && coin_drop_upgrade_buy[0] && coin_drop_upgrade_buy[1] && !coin_drop_upgrade_buy[2]) {
            buy_success_image_coin_drop[2].sprite = tick_icon;
            coin_drop_upgrade_buy[2] = true;
            game_ui.coin_drop_add = 80;
            money -= 700f;
        }
    }
}