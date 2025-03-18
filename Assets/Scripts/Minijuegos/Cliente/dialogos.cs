using NUnit.Framework;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class dialogos : MonoBehaviour
{
    [SerializeField] TextMeshPro clienteDialoge;
    [SerializeField] TextMeshPro YoshiroDialoge;
    [SerializeField] TextMeshPro AyaneDialoge;
    [SerializeField] TextMeshPro UsugiDialoge;


    // Dialogos clientes
    [SerializeField] string tipo_1;

    //Pedidos
    [SerializeField] public  string X;
    [SerializeField] public string Y;
    [SerializeField] public string Z;

    //Conversacion Escena 1

    public string Escena1_dialoge_1 = "Sigo pensando que este trabajo no es el mejor que pod�a tener, pero el horario es muy bueno y el sueldo no est� tan mal comparado con otros trabajos que he buscado. Adem�s, �c�mo es que estos sitios tienen tanta fama? Nunca lo entender�, la �";
    public string Escena1_dialoge_2 = "�Bienvenida! �Usagi, verdad? �Est�s lista para tu primer d�a? No te preocupes, te ense�ar� todo lo que necesitas saber.";
    public string Escena1_dialoge_3 = "Gracias por el recibimiento, s� que suena un poco pesimista, pero estaba asustada\r\nde empezar a trabajar aqu�.";
    public string Escena1_dialoge_4 = "Soy consciente que los Maid Caf� tienen mala fama y no puedo negar que el ambiente muchas veces es inc�modo con ciertos clientes, tienes que saber cuidarse de ellos; la mayor�a suele ser amable, pero alguno que otro querr� sobrepasarse contigo, es por eso que yo prefiero estar en cocina y tratar lo menos posible con la clientela, admiro a las que s� pueden estar de cara al p�blico. A�n as�, este lugar suele ser tranquilo, no vienen tantos clientes y seguro te las arreglas bien.";
    public string Escena1_dialoge_5 = "Puede que este no sea el mejor lugar, pero de verdad necesitaba el dinero que ofrecen, puedo con la presi�n, no hay ning�n problema.";
    public string Escena1_dialoge_6 = "As� se habla, s� que lo har�s perfecto, se nota que eres muy buena. Cualquier problema que tengas, ven a hablar conmigo.";
    public string Escena1_dialoge_7 = "Bien, empecemos con lo b�sico. Para moverse, solo hace falta que uses las teclas WASD: W para moverse hacia adelante, A hacia la izquierda, S hacia atr�s y D para la derecha.";

    public string Escena1_dialoge_8 = "Esta es la zona de los batidos y caf�s, situada justo al lado de la cocina. Aqu� es donde preparar�s los pedidos. Para hacer los batidos, solo bastar� con ir al almac�n; que te ense�ar� m�s tarde, a por el ingrediente principal del batido que te pidan. Para pillar ingredientes, objetos, etc. Pulsa la tecla �E�. Para dejarlo dentro de la batidora, pulsa la tecla �F�, y para hacer el batido mant�n �RMB� hasta que salga todo, despu�s d�jalo en la bandeja. Lo mismo con la cafetera, escoges el ingrediente necesario, lo a�ades y mantienes hasta que est� listo, y lo dejas en la bandeja. Si te piden agua, est� en la nevera que tienes debajo de la barra, y si te piden algo de comida no te preocupes, �Ves esa ventanilla de\r\nah�? Yo estar� en la cocina, solo har� falta que con RMB pulses la campanita. Cuando est� lista, te avisar� con esta misma y te la dejar� ah� apoyada.";

    public string Escena1_dialoge_9 = "Este es el comedor, donde atender�s a los clientes a medida que vayan llegando. Al tomarles el pedido, es importante saludarlos y que les llames �amo�, �mi se�or� o como ellos quieran que les digas. Se que suena raro, pero es lo que nos hace �nicos. Adem�s, debes tener cuidado con no tardar en llevarles los pedidos.";
    
    public string Escena1_dialoge_10 = "Lo �ltimo que tengo que ense�arte es el almac�n y cuarto de empleados. Aqu� podr�s pillar algunos de los ingredientes que te har�n falta, y el sitio donde tenemos las taquillas donde guardamos los uniformes. Adem�s tenemos un espejo para vernos antes de salir. �Sencillo, verdad? Pues esta es tu taquilla, c�mbiate y empecemos tu primer servicio.";


    // Conversacion Escena 3
    public string Escena3_dialoge_1 = "Bienvenido a Amodoro Maid Caf�. �Qu� desea pedir amo?";
    public string Escena3_dialoge_2 = "�Hola, mi nombre es Yoshiro, un gusto conocerte!";
    public string Escena3_dialoge_3 = "...";
    public string Escena3_dialoge_4 = "�Qu� me recomiendas? Seguro que tienes muy buen gusto.";
    public string Escena3_dialoge_5 = "La verdad es que es mi primer d�a, a�n no estoy familiarizada con todo lo del men�, pero estoy segura de que sea lo que sea que pidas va a estar muy rico.";
    public string Escena3_dialoge_6;
    public string Escena3_dialoge_7 = "�Podr�as traerme una caja de harina cuando acabes con ese cliente, por favor? Est� en el almac�n.";
    public string Escena3_dialoge_8 = "Muchas gracias preciosa.";


    //Conversacion 1 Escena 6 

    public string Escena6_dialoge_1 = "Hola, soy Usagi, empec� a trabajar ayer. Ayane no me hab�a dicho nada de otra compa�era.";
    public string Escena6_dialoge_2 = "Puede ser que se le olvidara, he tenido que estar ausente. Por cierto, me llamo\r\nKyoko. Yo estoy en el escenario haciendo los shows. �Qu� te ha parecido tu primer d�a?";
    public string Escena6_dialoge_3 = "Todo bien, ha sido m�s tranquilo de lo que me esperaba, aunque Ayane tiene raz�n y hay algunos clientes extra�os.";
    public string Escena6_dialoge_4 = "Con el tiempo te acostumbrar�s. Ayer de hecho vino un amigo m�o a tomar algo, probablemente lo atendiste, se llama Yoshiro, es muy buena gente cuando lo conoces bien.";
    public string Escena6_dialoge_5 = "Ahh� si� S� que lo atend�, seguro que se ve buena gente�";
    public string Escena6_dialoge_6 = "Veo que vosotras dos ya os hab�is conocido. �Lista para otro d�a de esclavitud, Usagi? Bien pues a cambiarse que tenemos que empezar el servicio.";
    public string Escena6_dialoge_7 = "Ja, ja� Muy graciosa, Ayane.";

    //Conversacion 2 Escena 6 

    public string Escena6_dialoge_8 = "Veo que no me has querido escribir� No pasa nada guapa, para que no te de verg�enza te traje un peque�o regalito.";
    public string Escena6_dialoge_9 = "No creo que sea correcto aceptar regalos de mis clientes.";
    public string Escena6_dialoge_10 = "No te preocupes, pero a la pr�xima puedes escribirme sin miedo guapa.";
    public string Escena6_dialoge_11 = "�Qu� quieres pedir, mi se�or?";
    public string Escena6_dialoge_12 = "Quiero una MofuMofu Carrot y dos botellas de agua por favor, preciosa.";
    public string Escena6_dialoge_13 = "Enseguida. Nos vamos detr�s del mostrador y le pasamos las ordenes a Ayane.";
    public string Escena6_dialoge_14 = "�Podr�as traerme una caja de huevos del dep�sito cuando termines all�, por favor?\r\nHoy el d�a est� m�s ajetreado que ayer.";

    void Start()
    {
        tipo_1 = X + Y + Z +"por favor.";

        tipo_1 = "Has tardado mucho. Me gustar�a" + X + Y + Z;

        Escena3_dialoge_6 = "Pues ponme" + X + Y + Z + ", por favor preciosa.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
