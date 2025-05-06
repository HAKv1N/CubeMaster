using UnityEngine;

public class Activator : MonoBehaviour
{
    public GameObject[] firstGroup;
    public GameObject[] secondGroup;
    public Activator button;
    public Material normal;
    public Material transparent;
    [SerializeField] private AudioSource button_audio => GetComponent<AudioSource>();
  

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube") || other.CompareTag("Player")) {
            button_audio.enabled = true;
            button_audio.Play();

            foreach (GameObject first in firstGroup) {
                first.GetComponent<Renderer>().material = normal;
                first.GetComponent<Collider>().isTrigger = false;
            }

            foreach (GameObject second in secondGroup) {
                second.GetComponent<Renderer>().material = transparent;
                second.GetComponent<Collider>().isTrigger = true;
            }
        }
    }
}