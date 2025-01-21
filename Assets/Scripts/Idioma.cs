using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Idioma : MonoBehaviour
{
    static public int Idiomas;

    
    public void idioma()
    {




    }
    public void flecha_1()
    {
        Idiomas++;
        if (Idiomas >= 2)
        {
            Idiomas = 1;
        }
    }

    public void flecha_2()
    {
        Idiomas--;
        if (Idiomas <= -1)
        {
            Idiomas = 0;
        }
    }

    
}
