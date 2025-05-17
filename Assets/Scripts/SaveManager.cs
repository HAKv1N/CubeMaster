using UnityEngine;
using YG;

public class SaveManager : MonoBehaviour
{
    private void Start() {
        Load();
    }

    public void Save() {
        YandexGame.savesData.money = shop.money;
        YandexGame.savesData.lvls_complete = select_level.lvls_complete;
        YandexGame.savesData.music_volume = menu_ui.music_volume;
        YandexGame.savesData.skins_buy = shop.skins_buy;
        YandexGame.savesData.coin_upgrade_buy = shop.coin_upgrade_buy;
        YandexGame.savesData.coin_drop_upgrade_buy = shop.coin_drop_upgrade_buy;

        YandexGame.SaveProgress();
    }

    private void Load() {
        shop.money = YandexGame.savesData.money;
        select_level.lvls_complete = YandexGame.savesData.lvls_complete;
        menu_ui.music_volume = YandexGame.savesData.music_volume;
        shop.skins_buy = YandexGame.savesData.skins_buy;
        shop.coin_upgrade_buy = YandexGame.savesData.coin_upgrade_buy;
        shop.coin_drop_upgrade_buy = YandexGame.savesData.coin_drop_upgrade_buy;
    }
}