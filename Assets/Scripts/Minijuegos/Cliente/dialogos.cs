using System.Collections;
using NUnit.Framework;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class dialogos : MonoBehaviour
{
    // conejo
    [SerializeField] GameObject Conejo;
    //permitir salir

    public bool Salir;

    // Imagenes
    [SerializeField] GameObject Nota_Yoshiro;
    [SerializeField] public GameObject Fin_Demo;
    //Dias
    public bool dia_1;
    public bool dia_2;
    //Parar, moviniento
    [SerializeField] Moverse Mv;

    // Lugar para Ayane
    [SerializeField] IA_basica IB;
    [SerializeField] GameObject AY;
    [SerializeField] Transform[] obj;

    [SerializeField] IA_basica IB_2;
    [SerializeField] GameObject AY_2;
    [SerializeField] Transform[] obj_2;

    //textos personajes
    [SerializeField] TextMeshProUGUI ClienteDialoge;
    [SerializeField] TextMeshProUGUI YoshiroDialoge;
    [SerializeField] TextMeshProUGUI AyaneDialoge;
    [SerializeField] TextMeshProUGUI UsugiDialoge;
    [SerializeField] TextMeshProUGUI KyokoDialoge;

    //Gameobje personajes
    [SerializeField] GameObject ClienteObject;
    [SerializeField] GameObject YoshiroObject;
    [SerializeField] GameObject AyaneObject;
    [SerializeField] GameObject UsugiObject;
    [SerializeField] GameObject KyokoObject;


    // Dialogos clientes
    [SerializeField] string tipo_1;
    public bool Convers_1;

    //Pedidos
    [SerializeField] public  string X;
    [SerializeField] public string Y;
    [SerializeField] public string Z;

    //Dialogos hitgun
    public bool S;
    public bool T;
    public bool U;
    public bool W;
    public bool W2;
    public bool U2;
    public bool W3;

    //Conver_Yoriro
    public bool Yoshiro_1;
    public bool Yoshi_D_1;
    public bool Yoshiro_2;
    public bool Yoshi_D_2;

    //Conversacion
    int pagina;
    public bool Convers_2;

    public bool Convers_3;

    public bool leer;

    //Sonido
    [SerializeField] AudioSource Susto;
    [SerializeField] AudioSource Hablar;
    [SerializeField] AudioSource Cliente;
    
    string Escena1_dialoge_1 = "Sigo pensando que este trabajo no es el mejor que podía tener, pero el horario es muy bueno y el sueldo no está tan mal comparado con otros trabajos que he buscado. Además, ¿cómo es que estos sitios tienen tanta fama? Nunca lo entenderé, la …";
    string Escena1_dialoge_2 = "¡Bienvenida! ¿Usagi, verdad? ¿Estás lista para tu primer día? No te preocupes, te enseñaré todo lo que necesitas saber.";
    string Escena1_dialoge_3 = "Gracias por el recibimiento, sé que suena un poco pesimista, pero estaba asustada de empezar a trabajar aquí.";
    string Escena1_dialoge_4 = "Soy consciente que los Maid Café tienen mala fama y no puedo negar que el ambiente muchas veces es incómodo con ciertos clientes, tienes que saber cuidarse de ellos. ";
    string Escena1_dialoge_4_2 ="La mayoría suele ser amable, pero alguno que otro querrá sobrepasarse contigo, es por eso que yo prefiero estar en cocina y tratar lo menos posible con la clientela, admiro a las que sí pueden estar de cara al público. Aún así, este lugar suele ser tranquilo, no vienen tantos clientes y seguro te las arreglas bien.";
    string Escena1_dialoge_5 = "Puede que este no sea el mejor lugar, pero de verdad necesitaba el dinero que ofrecen, puedo con la presión, no hay ningún problema.";
    string Escena1_dialoge_6 = "Así se habla, sé que lo harás perfecto, se nota que eres muy buena. Cualquier problema que tengas, ven a hablar conmigo.";
    string Escena1_dialoge_7 = "Bien, empecemos con lo básico. Para moverse, solo hace falta que uses las teclas WASD: W para moverse hacia adelante, A hacia la izquierda, S hacia atrás y D para la derecha.";

    string Escena1_dialoge_7_2 = "Bien, sigueme";
    string Escena1_dialoge_8 = "Esta es la zona de los batidos y cafés, situada justo al lado de la cocina. Aquí es donde prepararás los pedidos. Para hacer los batidos, solo bastará con ir al almacén; que te enseñaré más tarde, a por el ingrediente principal del batido que te pidan. Para pillar ingredientes, objetos, etc. Pulsa la tecla “E”.";
    string Escena1_dialoge_8_3 = " Para dejarlo dentro de la batidora, pulsa la tecla “E”, y para hacer el batido mantén “RMB” hasta que salga todo, después déjalo en la bandeja. Lo mismo con la cafetera, escoges el ingrediente necesario, lo añades y mantienes hasta que esté listo, y lo dejas en la bandeja.";
    string Escena1_dialoge_8_4 = " Si te piden agua, está en la nevera, y si te piden algo de comida no te preocupes, ¿Ves esa ventanilla de ahí? Yo estaré en la cocina, solo hará falta que con RMB pulses la campanita. Cuando esté lista, te avisaré con esta misma y te la dejaré ahí apoyada.";
    string Escena1_dialoge_8_5 = "Cuando tengas la bandeja en la mano no pierdas el equilibrio, para mantenerlo utiliza la “Q” y la “R”. Si se te cae vuelve a pedir la comida en la ventanilla";

    string Escena1_dialoge_8_2 = "Ven por aqui";
    string Escena1_dialoge_9 = "Este es el comedor, donde atenderás a los clientes a medida que vayan llegando. Al tomarles el pedido, es importante saludarlos y que les llames “amo”, “mi señor” o como ellos quieran que les digas. Se que suena raro, pero es lo que nos hace únicos. Además, debes tener cuidado con no tardar en llevarles los pedidos.";

    string Escena1_dialoge_9_2 = "";
    string Escena1_dialoge_10 = "Lo último que tengo que enseñarte es el almacén y cuarto de empleados. Aquí podrás pillar algunos de los ingredientes que te harán falta, y el sitio donde tenemos las taquillas donde guardamos los uniformes.";
     string Escena1_dialoge_10_2 =   " Además tenemos un espejo para vernos antes de salir. ¿Sencillo, verdad? Pues esta es tu taquilla, cámbiate y empecemos tu primer servicio.";
    

    // Conversacion Escena 3
    string Escena3_dialoge_1 = "Bienvenido a Amodoro Maid Café. ¿Qué desea pedir amo?";
    string Escena3_dialoge_2 = "¡Hola, mi nombre es Yoshiro, un gusto conocerte!";
    string Escena3_dialoge_3 = "...";
    string Escena3_dialoge_4 = "¿Qué me recomiendas? Seguro que tienes muy buen gusto.";
    string Escena3_dialoge_5 = "La verdad es que es mi primer día, aún no estoy familiarizada con todo lo del menú, pero estoy segura de que sea lo que sea que pidas va a estar muy rico.";
    string Escena3_dialoge_6;
    string Escena3_dialoge_7 = "Usagi, ¿Podrías traerme una caja de harina cuando acabes con ese cliente, por favor? Está en el almacén.";
    string Escena3_dialoge_8 = "Muchas gracias preciosa, toma esto de mi parte.";
    public string Escena3_dialoge_9 = "Ya ha acabado tu turno, hoy termino yo de limpiar las mesas";
    public string Escena3_dialoge_10 = "Ah, muchas gracias";
    string Escena3_dialoge_11 = "¿Que estas mirando con tanta impetu?";
    string Escena3_dialoge_12 = "Una nota que me dejo ese cliente";
    string Escena3_dialoge_13 = "¿Qué tal tu primer día? Apostaría a que ha sido más fácil de lo que pensabas.";
    string Escena3_dialoge_14 = "Si.. Ha sido... interesante. Algunos clientes son amables. Otros... son un poco raros.";
    string Escena3_dialoge_15 = "Oh, eso es solo principio. Aquí verás de todo. Recuerda, sonríe siempre y mantén la distancia. No dejes que ningún cliente se te acerque demasiado, ¿de acuerdo?. Bueno, puedes irte ya termino yo todo lo que queda";
    string Escena3_dialoge_16 = "Muachas gracias, buenas noches";

    //Conversacion 1 Escena 6 

    string Escena6_dialoge_1 = "Hola, soy Usagi, empecé a trabajar ayer. Ayane no me había dicho nada de otra compañera.";
    string Escena6_dialoge_2 = "Puede ser que se le olvidara, he tenido que estar ausente. Por cierto, me llamo Kyoko. Yo estoy en el escenario haciendo los shows. ¿Qué te ha parecido tu primer día?";
    string Escena6_dialoge_3 = "Todo bien, ha sido más tranquilo de lo que me esperaba, aunque Ayane tiene razón y hay algunos clientes extraños.";
    string Escena6_dialoge_4 = "Con el tiempo te acostumbrarás. Ayer de hecho vino un amigo mío a tomar algo, probablemente lo atendiste, se llama Yoshiro, es muy buena gente cuando lo conoces bien.";
    string Escena6_dialoge_5 = "Ahh… si… Sí que lo atendí, seguro que se ve buena gente…";
    string Escena6_dialoge_6 = "Veo que vosotras dos ya os habéis conocido. ¿Lista para otro día de esclavitud, Usagi? Bien pues a cambiarse que tenemos que empezar el servicio.";
    string Escena6_dialoge_7 = "Ja, ja… Muy graciosa, Ayane.";

    //Conversacion 2 Escena 6 

    string Escena6_dialoge_8 = "Veo que no me has querido escribir… No pasa nada guapa, para que no te de vergüenza te traje un pequeño regalito.";
    string Escena6_dialoge_9 = "No creo que sea correcto aceptar regalos de mis clientes.";
    string Escena6_dialoge_10 = "No te preocupes, pero a la próxima puedes escribirme sin miedo guapa.";
    string Escena6_dialoge_11 = "¿Qué quieres pedir, mi señor?";
    string Escena6_dialoge_12 = "Quiero una MofuMofu Carrot y dos botellas de agua por favor, preciosa.";
    string Escena6_dialoge_13 = "Enseguida.";
    string Escena6_dialoge_14 = "¿Podrías traerme una caja de huevos del depósito cuando termines allí, por favor? Hoy el día está más ajetreado que ayer.";


    void Start()
    {
        X = null;
        Y = null;
        Z = null;

        Convers_1 = false;
        Convers_3 = false;
        pagina = 0;

        Convers_2 = true;

        Yoshi_D_1 = false;
    }

    public void Clin()
    {
        int R = Random.Range(0, 2);

        if (R == 0) 
        {
            if (X == null && Y !=null && Z!=null)
            {
                tipo_1 = Y + " y " + Z + "por favor.";

            }else if (Y == null && Z != null && X != null)
            {
                tipo_1 = X + " y " + Z + "por favor.";

            }else if (Z == null && X != null && Y != null )
            {
                tipo_1 = X + " y " + Y + "por favor.";

            }else if (X == null && Y == null && Z != null)
            {
                tipo_1 = "Solo una " + Z + " por favor.";

            }else if (X == null && Y != null && Z == null)
            {
                tipo_1 = "Solo un " + Y + " por favor.";

            }else if (X != null && Y == null && Z == null)
            {
                tipo_1 = "Solo un " + X + " por favor.";
            }else 
            { 
                tipo_1 = X +", " + Y + " y una " + Z + ", "+ "por favor.";
            }
            
            ClienteDialoge.text = tipo_1;
            X = null;
            Y = null;
            Z = null;
        }
        else if (R == 1) 
        {
            if (X == null && Y != null && Z != null)
            {
                tipo_1 = "Has tardado mucho. Me gustaría un " + Y + " y " + Z;

            }
            else if (Y == null && Z != null && X != null)
            {
                tipo_1 = "Has tardado mucho. Me gustaría un "+ X + " y " + Z;

            }
            else if (Z == null && X != null && Y != null)
            {
                tipo_1 = "Has tardado mucho. Me gustaría un " + X + " y " + Y;

            }
            else if (X == null && Y == null && Z != null)
            {
                tipo_1 = "Has tardado mucho. Me gustaría una "  + Z;

            }
            else if (X == null && Y != null && Z == null)
            {
                tipo_1 = "Has tardado mucho. Me gustaría un " + Y;
            }
            else if (X != null && Y == null && Z == null)
            {
                tipo_1 = "Has tardado mucho. Me gustaría un " + X;
            }
            else
            {
                tipo_1 = "Has tardado mucho. Me gustaría un " + X + ", " + Y + " y una " + Z;
            }

            ClienteDialoge.text = tipo_1;
            
            X = null;
            Y = null;
            Z = null;
        }

        ClienteObject.SetActive(true);
        Convers_1 = true;
        Mv.Stop = true;

    }

    public void Yoshiro()
    {
        if (Yoshiro_1)
        {
            Yoshi_D_1 = true;
        }
        if (Yoshiro_2)
        {
            Yoshi_D_2 = true;
        }
    }

    IEnumerator Tiempo(int j) 
    {
        yield return new WaitForSeconds(j/2);
        Nota_Yoshiro.SetActive(true);
        YoshiroObject.SetActive(false);
        yield return new WaitForSeconds(j);

        leer = true;
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && Convers_1)
        {
            ClienteObject.SetActive(false);
            Convers_1 = false;
            Mv.Stop = false;
        }

        if (dia_1)
        {
            if (Yoshi_D_1)
            {
                if (pagina == 0)
                {
                    
                    YoshiroObject.SetActive(false);
                    UsugiDialoge.text = Escena3_dialoge_1;
                    UsugiObject.SetActive(true);
                    pagina++;
                    Mv.Stop = true;

                }
                else if (pagina == 1 && Input.GetKeyUp(KeyCode.Space))
                {
                    Hablar.Stop();
                    Hablar.Play();
                    YoshiroObject.SetActive(true);
                    YoshiroDialoge.text = Escena3_dialoge_2;
                    UsugiObject.SetActive(false);
                    pagina++;

                }
                else if (pagina == 2 && Input.GetKeyUp(KeyCode.Space))
                {
                    Hablar.Stop();
                    YoshiroObject.SetActive(false);
                    UsugiDialoge.text = Escena3_dialoge_3;
                    UsugiObject.SetActive(true);
                    pagina++;
                }
                else if (pagina == 3 && Input.GetKeyUp(KeyCode.Space))
                {
                    Hablar.Stop();
                    Hablar.Play();
                    YoshiroObject.SetActive(true);
                    YoshiroDialoge.text = Escena3_dialoge_4;
                    UsugiObject.SetActive(false);
                    pagina++;
                }
                else if (pagina == 4 && Input.GetKeyUp(KeyCode.Space))
                {
                    Hablar.Stop();
                    YoshiroObject.SetActive(false);
                    UsugiDialoge.text = Escena3_dialoge_5;
                    UsugiObject.SetActive(true);
                    pagina++;

                }
                else if (pagina == 5 && Input.GetKeyUp(KeyCode.Space))
                {
                    Hablar.Stop();
                    Hablar.Play();
                    YoshiroObject.SetActive(true);

                    if (X == null && Y != null && Z != null)
                    {
                        Escena3_dialoge_6 = "Pues ponme un " + Y + " y una " + Z + ", por favor preciosa.";
                    }
                    else if (Y == null && Z != null && X != null)
                    {
                        Escena3_dialoge_6 = "Pues ponme un " + X + " y una " + Z + ", por favor preciosa.";
                    }
                    else if (Z == null && X != null && Y != null)
                    {

                        Escena3_dialoge_6 = "Pues ponme un " + X + " y un " + Y + ", por favor preciosa.";

                    }
                    else if (X == null && Y == null && Z != null)
                    {

                        Escena3_dialoge_6 = "Pues ponme sola un" + Z + ", por favor preciosa.";
                    }
                    else if (X == null && Y != null && Z == null)
                    {
                        Escena3_dialoge_6 = "Pues ponme un " + Y + ", por favor preciosa.";
                    }
                    else if (X != null && Y == null && Z == null)
                    {
                        Escena3_dialoge_6 = "Pues ponme un " + X + ", por favor preciosa.";
                    }
                    else
                    {
                        Escena3_dialoge_6 = "Pues ponme " + X + ", " + Y + " y " + Z + ", por favor preciosa.";
                    }
                    YoshiroDialoge.text = Escena3_dialoge_6;
                    UsugiObject.SetActive(false);
                    pagina++;

                }
                else if (pagina == 6 && Input.GetKeyUp(KeyCode.Space))
                {
                    Hablar.Stop();
                    UsugiObject.SetActive(false);
                    YoshiroObject.SetActive(false);
                    Mv.Stop = false;
                    S = true;
                    pagina = 0;
                    Yoshiro_2 = true;
                    Yoshiro_1 = false;
                    Yoshi_D_1 = false;
                }
            }
            if (T)
            {
                if (pagina == 0)
                {
                    Hablar.Stop();
                    Hablar.Play();
                    Mv.Stop = true;
                    UsugiObject.SetActive(false);
                    AyaneDialoge.text = Escena3_dialoge_7;
                    AyaneObject.SetActive(true);
                    pagina++;
                }
                else if (pagina == 1 && Input.GetKeyUp(KeyCode.Space))
                {
                    Hablar.Stop();
                    AyaneObject.SetActive(false);

                    Mv.Stop = false;
                    pagina = 0;
                    T = false;
                }
            }

            if (Yoshi_D_2)
            {
                if (pagina == 0)
                {
                    Mv.Stop = true;
                    UsugiObject.SetActive(false);
                    YoshiroDialoge.text = Escena3_dialoge_8;
                    YoshiroObject.SetActive(true);
                    pagina++;
                    StartCoroutine(Tiempo(10));



                }
                else if (pagina == 1 && leer)
                {
                    Susto.Play(); 
                    Hablar.Stop();
                    Hablar.Play();
                    AY.SetActive(true);
                    IB.objetivo = obj[6];
                    AY.transform.position = obj[6].transform.position;
                    IB.Look();
                    YoshiroObject.SetActive(false);
                    Nota_Yoshiro.SetActive(false);
                    UsugiObject.SetActive(false);
                    AyaneDialoge.text = Escena3_dialoge_11;
                    AyaneObject.SetActive(true);
                    pagina++;
                }
                else if (pagina == 2 && Input.GetKeyUp(KeyCode.Space))
                {
                    Hablar.Stop();
                    AyaneObject.SetActive(false);
                    UsugiDialoge.text = Escena3_dialoge_12;
                    UsugiObject.SetActive(true);
                    pagina++;
                }
                else if (pagina == 3 && Input.GetKeyUp(KeyCode.Space))
                {
                    Hablar.Stop();
                    Hablar.Play();
                    UsugiObject.SetActive(false);
                    AyaneDialoge.text = Escena3_dialoge_13;
                    AyaneObject.SetActive(true);
                    pagina++;
                }
                else if (pagina == 4 && Input.GetKeyUp(KeyCode.Space))
                {
                    Hablar.Stop();
                    AyaneObject.SetActive(false);
                    UsugiDialoge.text = Escena3_dialoge_14;
                    UsugiObject.SetActive(true);
                    pagina++;
                }
                else if (pagina == 5 && Input.GetKeyUp(KeyCode.Space))
                {
                    Hablar.Stop();
                    Hablar.Play();
                    UsugiObject.SetActive(false);
                    AyaneDialoge.text = Escena3_dialoge_15;
                    AyaneObject.SetActive(true);
                    pagina++;
                }
                else if (pagina == 6 && Input.GetKeyUp(KeyCode.Space))
                {
                    Hablar.Stop();
                    AyaneObject.SetActive(false);
                    UsugiDialoge.text = Escena3_dialoge_16;
                    UsugiObject.SetActive(true);
                    pagina++;
                }
                else if (pagina == 7 && Input.GetKeyUp(KeyCode.Space))
                {
                    AyaneObject.SetActive(false);
                    UsugiObject.SetActive(false);
                    Mv.Stop = false;
                    pagina = 0;
                    Yoshi_D_2 = false;
                    Salir = true;
                }
            }
        }
        if (Convers_2 && dia_1)
        {
            if (Convers_2 && pagina == 0)
            {
                IB.objetivo = obj[0];
                UsugiDialoge.text = Escena1_dialoge_1;
                UsugiObject.SetActive(true);
                pagina++;
                Mv.Stop = true;
            }
            else if (Convers_2 && new Vector3(IB.transform.position.x, 0, IB.transform.position.z) == new Vector3(obj[0].transform.position.x, 0, obj[0].transform.position.z) && pagina == 1)
            {
                Hablar.Play();
                UsugiObject.SetActive(false);
                AyaneDialoge.text = Escena1_dialoge_2;
                AyaneObject.SetActive(true);
                pagina++;

            }
            else if (Convers_2 && pagina == 2 && Input.GetKeyUp(KeyCode.Space))
            {
                Hablar.Stop();
                AyaneObject.SetActive(false);
                UsugiDialoge.text = Escena1_dialoge_3;
                UsugiObject.SetActive(true);
                pagina++;
            }
            else if (Convers_2 && pagina == 3 && Input.GetKeyUp(KeyCode.Space))
            {
                Hablar.Play();
                UsugiObject.SetActive(false);
                AyaneDialoge.text = Escena1_dialoge_4;
                AyaneObject.SetActive(true);
                pagina++;
            }
            else if (Convers_2 && pagina == 4 && Input.GetKeyUp(KeyCode.Space))
            {
                Hablar.Stop();
                Hablar.Play();
                AyaneObject.SetActive(true);
                AyaneDialoge.text = Escena1_dialoge_4_2;
                UsugiObject.SetActive(false);
                pagina++;
            }
            else if (Convers_2 && pagina == 5 && Input.GetKeyUp(KeyCode.Space))
            {
                Hablar.Stop();
                AyaneObject.SetActive(false);
                UsugiDialoge.text = Escena1_dialoge_5;
                UsugiObject.SetActive(true);
                pagina++;
            }
            else if (Convers_2 && pagina == 6 && Input.GetKeyUp(KeyCode.Space))
            {
                Hablar.Stop();
                Hablar.Play();
                UsugiObject.SetActive(false);
                AyaneDialoge.text = Escena1_dialoge_6;
                AyaneObject.SetActive(true);
                pagina++;
                pagina++;
            }
            else if (Convers_2 && pagina == 8 && Input.GetKeyUp(KeyCode.Space))
            {
                Hablar.Stop();
                AyaneDialoge.text = Escena1_dialoge_7;
                pagina++;
                Mv.Stop = false;
            }
            else if (Convers_2 && pagina == 9 && Input.GetKeyUp(KeyCode.W))
            {
                AyaneDialoge.text = Escena1_dialoge_7_2;
                pagina++;
                IB.objetivo = obj[1];
            }
            else if (new Vector3(IB.transform.position.x, 0, IB.transform.position.z) == new Vector3(obj[1].transform.position.x, 0, obj[1].transform.position.z) && Convers_2 && pagina == 10)
            {
                Hablar.Stop();
                Hablar.Play();
                AyaneDialoge.text = Escena1_dialoge_8;
                pagina++;

            }
            else if (Convers_2 && pagina == 11 && Input.GetKeyUp(KeyCode.Space))
            {
                Hablar.Stop();
                Hablar.Play();
                AyaneObject.SetActive(true);
                AyaneDialoge.text = Escena1_dialoge_8_3;
                UsugiObject.SetActive(false);
                pagina++;
            }
            else if (Convers_2 && pagina == 12 && Input.GetKeyUp(KeyCode.Space))
            {
                Hablar.Stop();
                Hablar.Play();
                AyaneObject.SetActive(true);
                AyaneDialoge.text = Escena1_dialoge_8_4;
                UsugiObject.SetActive(false);
                pagina++;
            }
            else if (Convers_2 && pagina == 13 && Input.GetKeyUp(KeyCode.Space))
            {
                Hablar.Stop();
                Hablar.Play();
                AyaneObject.SetActive(true);
                AyaneDialoge.text = Escena1_dialoge_8_5;
                UsugiObject.SetActive(false);
                pagina++;
            }
            else if ((Convers_2 && pagina == 14 && Input.GetKeyUp(KeyCode.Space)))
            {
                Hablar.Stop();
                IB.objetivo = obj[2];
                AyaneDialoge.text = Escena1_dialoge_8_2;
                pagina++;
            }
            else if (new Vector3(IB.transform.position.x, 0, IB.transform.position.z) == new Vector3(obj[2].transform.position.x, 0, obj[2].transform.position.z) && Convers_2 && pagina == 15)
            {
                Hablar.Stop();
                Hablar.Play();
                AyaneDialoge.text = Escena1_dialoge_9;
                pagina++;
            }
            else if (Convers_2 && pagina == 16 && Input.GetKeyUp(KeyCode.Space))
            {
                Hablar.Stop();
                Hablar.Play();
                IB.objetivo = obj[3];
                AyaneDialoge.text = Escena1_dialoge_9_2;
                pagina++;
            }
            else if (new Vector3(IB.transform.position.x, 0, IB.transform.position.z) == new Vector3(obj[3].transform.position.x, 0, obj[3].transform.position.z) && Convers_2 && pagina == 17)
            {
                Hablar.Stop();
                AyaneDialoge.text = Escena1_dialoge_10;
                pagina++;
            }
            else if (Convers_2 && pagina == 18 && Input.GetKeyUp(KeyCode.Space))
            {
                Hablar.Stop();
                Hablar.Play();
                AyaneObject.SetActive(true);
                AyaneDialoge.text = Escena1_dialoge_10_2;
                UsugiObject.SetActive(false);
                pagina++;
            }
            else if (Convers_2 && pagina == 19 && Input.GetKeyUp(KeyCode.Space))
            {
                Hablar.Stop();
                AyaneObject.SetActive(false);
                IB.objetivo = obj[4];
                pagina++;
            }
            else if (new Vector3(IB.transform.position.x, 0, IB.transform.position.z) == new Vector3(obj[4].transform.position.x, 0, obj[4].transform.position.z) && Convers_2 && pagina == 20)
            {

                IB.objetivo = obj[5];

                IB.transform.position = obj[5].position;

                AY.transform.position = obj[5].transform.position;


                AY.SetActive(false);

                Convers_2 = false; pagina = 0;
            }


        }

        if (dia_2)
        {
            if (Convers_3)
            {
                if (U && pagina == 0 )
                {
                    Mv.Stop = true;
                    UsugiObject.SetActive(true);
                    UsugiDialoge.text = Escena6_dialoge_1;
                    KyokoObject.SetActive(false);
                    pagina++;
                }
                else if (U && pagina == 1 && Input.GetKeyDown(KeyCode.Space))
                {
                    Hablar.Stop();
                    Hablar.Play();
                    UsugiObject.SetActive(false);
                    KyokoDialoge.text = Escena6_dialoge_2;
                    KyokoObject.SetActive(true);
                    pagina++;
                }
                else if (U && pagina == 2 && Input.GetKeyDown(KeyCode.Space))
                {
                    Hablar.Stop();
                    UsugiObject.SetActive(true);
                    UsugiDialoge.text = Escena6_dialoge_3;
                    KyokoObject.SetActive(false);
                    pagina++;
                    AY.transform.position = obj[1].transform.position;
                    IB.objetivo = obj[1];
                    AY.transform.position = obj[1].transform.position;
                }
                else if (U && pagina == 3 && Input.GetKeyDown(KeyCode.Space))
                {
                    Hablar.Stop();
                    Hablar.Play();
                    UsugiObject.SetActive(false);
                    KyokoDialoge.text = Escena6_dialoge_4;
                    KyokoObject.SetActive(true);
                    pagina++;
                    
                }
                else if (U && pagina == 4 && Input.GetKeyDown(KeyCode.Space))
                {
                    Hablar.Stop();
                    UsugiObject.SetActive(true);
                    UsugiDialoge.text = Escena6_dialoge_5;
                    KyokoObject.SetActive(false);
                    pagina++;

                }
                else if (U && pagina == 5 && new Vector3(obj[1].position.x,0, obj[1].position.z)== new Vector3(AY.transform.position.x, 0, AY.transform.position.z))
                {
                    Hablar.Stop();
                    Hablar.Play();
                    UsugiObject.SetActive(false);
                    AyaneDialoge.text = Escena6_dialoge_6;
                    KyokoObject.SetActive(false);
                    AyaneObject.SetActive(true);
                    pagina++;
                }
                else if (U && pagina == 6 && Input.GetKeyDown(KeyCode.Space))
                {
                    Hablar.Stop();
                    UsugiObject.SetActive(true);
                    UsugiDialoge.text = Escena6_dialoge_7;
                    KyokoObject.SetActive(false);
                    AyaneObject.SetActive(false);
                    pagina++;
                }else if (U && pagina == 7 && Input.GetKeyDown(KeyCode.Space))
                {
                    Hablar.Stop();
                    IB.objetivo = obj[2];
                    
                    UsugiObject.SetActive(false);
                    
                    IB_2.objetivo = obj_2[1];
                    
                    Mv.Stop = false;
                    pagina++;
                }else if (new Vector3(obj[2].position.x, 0, obj[2].position.z) == new Vector3(AY.transform.position.x, 0, AY.transform.position.z) && (new Vector3(obj_2[1].position.x, 0, obj_2[1].position.z) == new Vector3(AY_2.transform.position.x, 0, AY_2.transform.position.z) && pagina ==8))
                 {
                    AY.SetActive(false);
                    AY_2.SetActive(false);
                    pagina = 0;
                    U = false;
                    W = true;
                }

                if (W)
                {
                    if (W2 && pagina==0)
                    {
                        Hablar.Stop();
                        Hablar.Play();
                        Mv.Stop = true;
                        UsugiObject.SetActive(false);
                        YoshiroDialoge.text = Escena6_dialoge_8;
                        YoshiroObject.SetActive(true);
                        pagina++;

                    }else if (W2 && pagina == 1 && Input.GetKeyDown(KeyCode.Space))
                    {
                        Hablar.Stop();
                        UsugiObject.SetActive(true);
                        UsugiDialoge.text = Escena6_dialoge_9;
                        YoshiroObject.SetActive(false);
                        pagina++;
                    }else if (W2 && pagina == 2 && Input.GetKeyDown(KeyCode.Space))
                    {
                        Hablar.Stop();
                        Hablar.Play();
                        UsugiObject.SetActive(false);
                        YoshiroDialoge.text = Escena6_dialoge_10;
                        YoshiroObject.SetActive(true);
                        pagina++;
                    }else if (W2 && pagina == 3 && Input.GetKeyDown(KeyCode.Space))
                    {
                        Hablar.Stop();
                        UsugiObject.SetActive(true);
                        UsugiDialoge.text = Escena6_dialoge_11;
                        YoshiroObject.SetActive(false);
                        pagina++;
                    }else if (W2 && pagina == 4 && Input.GetKeyDown(KeyCode.Space))
                    {
                        Hablar.Stop();
                        Hablar.Play();
                        UsugiObject.SetActive(false);
                        YoshiroDialoge.text = Escena6_dialoge_12;
                        YoshiroObject.SetActive(true);
                        pagina++;
                    }else if (W2 && pagina == 5 && Input.GetKeyDown(KeyCode.Space))
                    {
                        Hablar.Stop();
                        UsugiObject.SetActive(true);
                    UsugiDialoge.text = Escena6_dialoge_13;
                    YoshiroObject.SetActive(false);
                    pagina++;
                    }else if (W2 && pagina == 6 && Input.GetKeyDown(KeyCode.Space))
                    {
                        UsugiObject.SetActive(false);
                        YoshiroObject.SetActive(false);
                        pagina = 0;
                        W = false;
                        U2 = true;
                        Mv.Stop = false;
                    }
                }

                if (U2) 
                { 
                    if (W3 && pagina == 0)
                    {
                        Hablar.Stop();
                        Hablar.Play();
                        Mv.Stop = true;
                        AyaneDialoge.text = Escena6_dialoge_14;
                        AyaneObject.SetActive(true);
                        pagina++;
                    }else if (W2 && pagina ==1  && Input.GetKeyDown(KeyCode.Space))
                    {
                        Hablar.Stop();
                        Mv.Stop=false;
                        AyaneObject.SetActive(false);
                        Conejo.SetActive(true);
                        pagina = 0;
                        U2=false;
                    }
                }
            }

        }
    }
}

