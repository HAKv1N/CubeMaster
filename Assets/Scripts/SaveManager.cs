using UnityEngine;
using YG;

public class SaveManager : MonoBehaviour
{
    public void Save()
    {
        YandexGame.savesData.money = shop.money;
        YandexGame.savesData.lvls_complete = select_level.lvls_complete;
        YandexGame.savesData.music_volume = menu_ui.music_volume;
        YandexGame.savesData.skins_buy = shop.skins_buy;
        YandexGame.savesData.coin_upgrade_buy = shop.coin_upgrade_buy;
        YandexGame.savesData.coin_drop_upgrade_buy = shop.coin_drop_upgrade_buy;
        YandexGame.savesData.ads_viewed_for_skin = shop.ads_viewed_for_skin;

        YandexGame.SaveProgress();
    }

    public void Load()
    {
        shop.money = YandexGame.savesData.money;
        select_level.lvls_complete = YandexGame.savesData.lvls_complete;
        menu_ui.music_volume = YandexGame.savesData.music_volume;
        shop.skins_buy = YandexGame.savesData.skins_buy;
        shop.coin_upgrade_buy = YandexGame.savesData.coin_upgrade_buy;
        shop.coin_drop_upgrade_buy = YandexGame.savesData.coin_drop_upgrade_buy;
        shop.ads_viewed_for_skin = YandexGame.savesData.ads_viewed_for_skin;
    }
}