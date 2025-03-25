using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Localization.SmartFormat.Utilities;
using UnityEngine.UI;

public class Musica : MonoBehaviour
{
    [SerializeField] AudioSource musicSoucer;

    [SerializeField] Slider musicSlider;

    [SerializeField] Slider Sound;
   static float Value = 0.5f;
    public float x;

 
    void Start()
    {
        musicSlider.value = Value;
        
    }

    // Update is called once per frame
    void Update()
    {
        musicSoucer.volume = musicSlider.value;
        Value = musicSlider.value;
        x = Value;
    }
}
