using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Localization.Settings;


public class Idioma : MonoBehaviour
{
    static public int Idiomas;

    
    public void idioma()
    {

        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[Idiomas];


    }
    public void flecha_1()
    {
        Idiomas++;
        if (Idiomas >= 3)
        {
            Idiomas = 2;
        }
        idioma();
    }

    public void flecha_2()
    {
        Idiomas--;
        if (Idiomas <= -1)
        {
            Idiomas = 0;
        }
        idioma();
    }

    
}
