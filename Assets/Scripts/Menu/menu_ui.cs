using UnityEngine;
using UnityEngine.UI;

public class menu_ui : MonoBehaviour
{
    [SerializeField] public static float music_volume = 0.2f;
    [SerializeField] private Slider music_volume_slider;
    [SerializeField] private AudioSource music_audio => GetComponent<AudioSource>();

    private void Start() {
        music_audio.volume = music_volume;
        music_volume_slider.value = music_volume;
    }

    private void Update() {
        volume_change();
    }

    private void volume_change() {
        music_volume = music_volume_slider.value;
        music_audio.volume = music_volume;
    }
}