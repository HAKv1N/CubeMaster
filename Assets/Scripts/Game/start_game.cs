using UnityEngine;

public class start_game : MonoBehaviour
{
    [SerializeField] private int item_id;
    [SerializeField] private GameObject player_1;
    [SerializeField] private GameObject player_2;
    [SerializeField] private Mesh skin_1;

    private void Start() {
        item_id = shop_skins.item_1;
        if (item_id == 1) {
            player_1.GetComponent<MeshFilter>().mesh = skin_1;
        }
    }
}