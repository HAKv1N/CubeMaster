using UnityEngine;

public class start_game : MonoBehaviour
{
    [SerializeField] private int item_id;
    [SerializeField] private GameObject player_1;
    [SerializeField] private GameObject player_2;
    [SerializeField] private Mesh skin_1_1;
    [SerializeField] private Material skin_mat_1_1;
    [SerializeField] private Mesh skin_1_2;
    [SerializeField] private Material skin_mat_1_2;

    private void Start() {
        item_id = shop_skins.item_1;
        if (item_id == 1) {
            player_1.GetComponent<MeshFilter>().mesh = skin_1_1;
            player_1.GetComponent<MeshRenderer>().material = skin_mat_1_1;
            Bounds bounds_1_1 = player_1.GetComponent<MeshFilter>().sharedMesh.bounds;
            BoxCollider player_1_collider = player_1.GetComponent<BoxCollider>();
            player_1_collider.center = bounds_1_1.center;
            player_1_collider.size = bounds_1_1.size;
            player_1.transform.localScale = new Vector3(50, 50, 50);

            player_2.GetComponent<MeshFilter>().mesh = skin_1_2;
            player_2.GetComponent<MeshRenderer>().material = skin_mat_1_2;
            Bounds bounds_1_2 = player_2.GetComponent<MeshFilter>().sharedMesh.bounds;
            BoxCollider player_2_collider = player_2.GetComponent<BoxCollider>();
            player_2_collider.center = bounds_1_2.center;
            player_2_collider.size = bounds_1_2.size;
            player_2.transform.localScale = new Vector3(50, 50, 50);
        }
    }
}