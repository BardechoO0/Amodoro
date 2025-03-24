using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    

    public void CargarEscena(int escena)
    {
        SceneManager.LoadScene(escena);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
