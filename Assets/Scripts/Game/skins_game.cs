using UnityEditor;
using UnityEngine;

public class skins_game : MonoBehaviour
{
    [SerializeField] private int skin_id;
    [SerializeField] private GameObject player_1;
    [SerializeField] private GameObject player_2;
    [SerializeField] private GameObject[] skins_1 = new GameObject[6];
    [SerializeField] private GameObject[] skins_2 = new GameObject[6];
    [SerializeField] public static GameObject player_1_main;
    [SerializeField] public static GameObject player_2_main;

    private void Start() {
        skin_id = shop_skins.skin_id;
        if (skin_id <= 0) {
            player_1_main = player_1;
            player_2_main = player_2;
        }

        if (skin_id == 1) {
            player_1_main = skins_1[0];
            player_1_main.transform.position = player_1.transform.position;
            Destroy(player_1);
            player_1_main = Instantiate(player_1_main);

            player_2_main = skins_2[0];
            player_2_main.transform.position = player_2.transform.position;
            Destroy(player_2);
            player_2_main = Instantiate(player_2_main);
        }

        if (skin_id == 2) {
            player_1_main = skins_1[1];
            player_1_main.transform.position = player_1.transform.position;
            Destroy(player_1);
            player_1_main = Instantiate(player_1_main);

            player_2_main = skins_2[1];
            player_2_main.transform.position = player_2.transform.position;
            Destroy(player_2);
            player_2_main = Instantiate(player_2_main);
        }

        if (skin_id == 3) {
            player_1_main = skins_1[2];
            player_1_main.transform.position = player_1.transform.position;
            Destroy(player_1);
            player_1_main = Instantiate(player_1_main);

            player_2_main = skins_2[2];
            player_2_main.transform.position = player_2.transform.position;
            Destroy(player_2);
            player_2_main = Instantiate(player_2_main);
        }

        if (skin_id == 4) {
            player_1_main = skins_1[3];
            player_1_main.transform.position = player_1.transform.position;
            Destroy(player_1);
            player_1_main = Instantiate(player_1_main);

            player_2_main = skins_2[3];
            player_2_main.transform.position = player_2.transform.position;
            Destroy(player_2);
            player_2_main = Instantiate(player_2_main);
        }

        if (skin_id == 5) {
            player_1_main = skins_1[4];
            player_1_main.transform.position = player_1.transform.position;
            Destroy(player_1);
            player_1_main = Instantiate(player_1_main);

            player_2_main = skins_2[4];
            player_2_main.transform.position = player_2.transform.position;
            Destroy(player_2);
            player_2_main = Instantiate(player_2_main);
        }
    }
}