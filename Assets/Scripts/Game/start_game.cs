using UnityEngine;

public class start_game : MonoBehaviour
{
    [SerializeField] private int skin_id;
    [SerializeField] private GameObject player_1;
    [SerializeField] private GameObject player_2;
    [SerializeField] private Mesh[] skins_1 = new Mesh[2];
    [SerializeField] private Mesh[] skins_2 = new Mesh[2];
    [SerializeField] private Material[] materials_1 = new Material[2];
    [SerializeField] private Material[] materials_2 = new Material[2];

    private void Start() {
        skin_id = shop_skins.skin_id;
        if (skin_id == 1) {
            player_1.GetComponent<MeshFilter>().mesh = skins_1[0];
            player_1.GetComponent<MeshRenderer>().material = materials_1[0];
            Bounds bounds_1_1 = player_1.GetComponent<MeshFilter>().sharedMesh.bounds;
            BoxCollider player_1_collider = player_1.GetComponent<BoxCollider>();
            player_1_collider.center = bounds_1_1.center;
            player_1_collider.size = bounds_1_1.size;
            player_1.transform.localScale = new Vector3(50, 50, 50);

            player_2.GetComponent<MeshFilter>().mesh = skins_2[0];
            player_2.GetComponent<MeshRenderer>().material = materials_2[0];
            Bounds bounds_1_2 = player_2.GetComponent<MeshFilter>().sharedMesh.bounds;
            BoxCollider player_2_collider = player_2.GetComponent<BoxCollider>();
            player_2_collider.center = bounds_1_2.center;
            player_2_collider.size = bounds_1_2.size;
            player_2.transform.localScale = new Vector3(50, 50, 50);
        }

        if (skin_id == 2) {
            player_1.GetComponent<MeshFilter>().mesh = skins_1[1];
            player_1.GetComponent<MeshRenderer>().material = materials_1[1];
            Bounds bounds_2_1 = player_1.GetComponent<MeshFilter>().sharedMesh.bounds;
            BoxCollider player_1_collider = player_1.GetComponent<BoxCollider>();
            player_1_collider.center = bounds_2_1.center;
            player_1_collider.size = bounds_2_1.size;
            player_1.transform.localScale = new Vector3(50, 50, 50);

            player_2.GetComponent<MeshFilter>().mesh = skins_2[1];
            player_2.GetComponent<MeshRenderer>().material = materials_2[1];
            Bounds bounds_2_2 = player_2.GetComponent<MeshFilter>().sharedMesh.bounds;
            BoxCollider player_2_collider = player_2.GetComponent<BoxCollider>();
            player_2_collider.center = bounds_2_2.center;
            player_2_collider.size = bounds_2_2.size;
            player_2.transform.localScale = new Vector3(50, 50, 50);
        }
    }
}