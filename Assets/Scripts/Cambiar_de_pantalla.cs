using UnityEngine;

public class Cambiar_de_pantalla : MonoBehaviour
{
    [SerializeField] GameObject Inicio;

    [SerializeField] GameObject Confi;
    public void pantalla_inicio() {
    
     Inicio.SetActive(true);
     Confi.SetActive(false);
    }


    public void pantalla_confi()
    {

        Inicio.SetActive(false);
        Confi.SetActive(true);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
