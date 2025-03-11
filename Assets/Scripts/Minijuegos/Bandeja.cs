using UnityEngine;
using UnityEngine.UI;

public class Bandeja : MonoBehaviour
{
   
    [SerializeField]public Slider x;

    public float Speed;

    public float CaidaSpeed;

    public float Multi;

    float R;

    public bool minijuegoActivo;
    void Start()
    {
        x.maxValue = 1f; 
        
        x.minValue = -1f;

        x.value = 0f;

        x.value += Random.Range(0.1f, -0.1f);
    }

    public void Activ()
    {
        minijuegoActivo = true;
        x.maxValue = 1f;
        x.minValue = -1f;
        x.value = 0f;
        x.value += Random.Range(0.1f, -0.1f);
    }

    public void DesActiv()
    {
        minijuegoActivo = false;
        x.value = 0f;
    }
    void Update()
    {
        if (minijuegoActivo)
        {
            if (Input.GetKey(KeyCode.R))
            {
                x.value += Speed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.Q))
            {
                x.value -= Speed * Time.deltaTime;
            }

            if (x.value < 0f)
            {
                x.value -= CaidaSpeed * Time.deltaTime - (x.value / Multi * Time.deltaTime);

                R  = x.value;
            }
            else if (x.value > 0f)
            {
                x.value += CaidaSpeed * Time.deltaTime + (x.value / Multi * Time.deltaTime);

                R = x.value;
            }

            
          

            transform.localRotation= Quaternion.Euler(45 * R, 0, 0);
        }
    }
}
