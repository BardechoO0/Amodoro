using UnityEngine;
using UnityEngine.UI;

public class Musica : MonoBehaviour
{
    [SerializeField] AudioSource musicSoucer;

    [SerializeField] Slider musicSlider;

    public float Value;
    void Start()
    {
        musicSlider.value = musicSoucer.volume;

        Value =  musicSlider.value;
    }

    // Update is called once per frame
    void Update()
    {
        musicSoucer.volume = musicSlider.value;
    }
}
