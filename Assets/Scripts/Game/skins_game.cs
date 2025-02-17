using UnityEditor;
using UnityEngine;

public class skins_game : MonoBehaviour
{
    [SerializeField] private int skin_id;
    [SerializeField] private GameObject player_1;
    [SerializeField] private GameObject player_2;
    [SerializeField] private GameObject[] skins_1 = new GameObject[4];
    [SerializeField] private GameObject[] skins_2 = new GameObject[4];

    private void Start() {
        skin_id = shop_skins.skin_id;
        if (skin_id == 1) {
            GameObject skin_1_1 = skins_1[0];
            skin_1_1.transform.localScale = new Vector3(50, 50, 50);
            skin_1_1.transform.position = player_1.transform.position;
            Instantiate(skin_1_1);
            Destroy(player_1);

            GameObject skin_1_2 = skins_2[0];
            skin_1_2.transform.localScale = new Vector3(50, 50, 50);
            skin_1_2.transform.position = player_2.transform.position;
            Instantiate(skin_1_2);
            Destroy(player_2);
        }

        if (skin_id == 2) {
            GameObject skin_2_1 = skins_1[1];
            skin_2_1.transform.localScale = new Vector3(50, 50, 50);
            skin_2_1.transform.position = player_1.transform.position;
            Instantiate(skin_2_1);
            Destroy(player_1);

            GameObject skin_2_2 = skins_2[1];
            skin_2_2.transform.localScale = new Vector3(50, 50, 50);
            skin_2_2.transform.position = player_2.transform.position;
            Instantiate(skin_2_2);
            Destroy(player_2);
        }

        if (skin_id == 3) {
            GameObject skin_3_1 = skins_1[2];
            skin_3_1.transform.localScale = new Vector3(40, 40, 40);
            skin_3_1.transform.position = player_1.transform.position;
            Instantiate(skin_3_1);
            Destroy(player_1);

            GameObject skin_3_2 = skins_2[2];
            skin_3_2.transform.localScale = new Vector3(40, 40, 40);
            skin_3_2.transform.position = player_2.transform.position;
            Instantiate(skin_3_2);
            Destroy(player_2);
        }

        if (skin_id == 4) {
            GameObject skin_4_1 = skins_1[3];
            skin_4_1.transform.localScale = new Vector3(50, 50, 50);
            skin_4_1.transform.position = player_1.transform.position;
            Instantiate(skin_4_1);
            Destroy(player_1);

            GameObject skin_4_2 = skins_2[3];
            skin_4_2.transform.localScale = new Vector3(50, 50, 50);
            skin_4_2.transform.position = player_2.transform.position;
            Instantiate(skin_4_2);
            Destroy(player_2);
        }
    }
}