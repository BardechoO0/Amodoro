using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Localization.SmartFormat.Utilities;
using UnityEngine.UI;

public class Musica : MonoBehaviour
{
    [SerializeField] AudioSource musicSoucer;

    [SerializeField] Slider musicSlider;

    [SerializeField] Slider Sound;
    static public float Value = 1f;

 
    void Start()
    {      
        
    }

    // Update is called once per frame
    void Update()
    {
        musicSoucer.volume = musicSlider.value;
    }
}
