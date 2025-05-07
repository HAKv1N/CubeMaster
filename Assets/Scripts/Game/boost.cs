using UnityEngine;

public class Boost : MonoBehaviour
{
    [SerializeField] private Vector3 player_moveDirection_start;
    void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Boost") && other.CompareTag("Player")) {
            Player player = other.gameObject.GetComponent<Player>();
            player_moveDirection_start = player.moveDirection;

            player.moveDirection += player_moveDirection_start;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (CompareTag("Boost") && other.CompareTag("Player")) {
            Player player = other.gameObject.GetComponent<Player>();

            player.moveDirection = player_moveDirection_start;
        }
    }
}