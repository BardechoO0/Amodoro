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

    public string Escena1_dialoge_1 = "Sigo pensando que este trabajo no es el mejor que podía tener, pero el horario es muy bueno y el sueldo no está tan mal comparado con otros trabajos que he buscado. Además, ¿cómo es que estos sitios tienen tanta fama? Nunca lo entenderé, la …";
    public string Escena1_dialoge_2 = "¡Bienvenida! ¿Usagi, verdad? ¿Estás lista para tu primer día? No te preocupes, te enseñaré todo lo que necesitas saber.";
    public string Escena1_dialoge_3 = "Gracias por el recibimiento, sé que suena un poco pesimista, pero estaba asustada\r\nde empezar a trabajar aquí.";
    public string Escena1_dialoge_4 = "Soy consciente que los Maid Café tienen mala fama y no puedo negar que el ambiente muchas veces es incómodo con ciertos clientes, tienes que saber cuidarse de ellos; la mayoría suele ser amable, pero alguno que otro querrá sobrepasarse contigo, es por eso que yo prefiero estar en cocina y tratar lo menos posible con la clientela, admiro a las que sí pueden estar de cara al público. Aún así, este lugar suele ser tranquilo, no vienen tantos clientes y seguro te las arreglas bien.";
    public string Escena1_dialoge_5 = "Puede que este no sea el mejor lugar, pero de verdad necesitaba el dinero que ofrecen, puedo con la presión, no hay ningún problema.";
    public string Escena1_dialoge_6 = "Así se habla, sé que lo harás perfecto, se nota que eres muy buena. Cualquier problema que tengas, ven a hablar conmigo.";
    public string Escena1_dialoge_7 = "Bien, empecemos con lo básico. Para moverse, solo hace falta que uses las teclas WASD: W para moverse hacia adelante, A hacia la izquierda, S hacia atrás y D para la derecha.";

    public string Escena1_dialoge_8 = "Esta es la zona de los batidos y cafés, situada justo al lado de la cocina. Aquí es donde prepararás los pedidos. Para hacer los batidos, solo bastará con ir al almacén; que te enseñaré más tarde, a por el ingrediente principal del batido que te pidan. Para pillar ingredientes, objetos, etc. Pulsa la tecla “E”. Para dejarlo dentro de la batidora, pulsa la tecla “F”, y para hacer el batido mantén “RMB” hasta que salga todo, después déjalo en la bandeja. Lo mismo con la cafetera, escoges el ingrediente necesario, lo añades y mantienes hasta que esté listo, y lo dejas en la bandeja. Si te piden agua, está en la nevera que tienes debajo de la barra, y si te piden algo de comida no te preocupes, ¿Ves esa ventanilla de\r\nahí? Yo estaré en la cocina, solo hará falta que con RMB pulses la campanita. Cuando esté lista, te avisaré con esta misma y te la dejaré ahí apoyada.";

    public string Escena1_dialoge_9 = "Este es el comedor, donde atenderás a los clientes a medida que vayan llegando. Al tomarles el pedido, es importante saludarlos y que les llames “amo”, “mi señor” o como ellos quieran que les digas. Se que suena raro, pero es lo que nos hace únicos. Además, debes tener cuidado con no tardar en llevarles los pedidos.";
    
    public string Escena1_dialoge_10 = "Lo último que tengo que enseñarte es el almacén y cuarto de empleados. Aquí podrás pillar algunos de los ingredientes que te harán falta, y el sitio donde tenemos las taquillas donde guardamos los uniformes. Además tenemos un espejo para vernos antes de salir. ¿Sencillo, verdad? Pues esta es tu taquilla, cámbiate y empecemos tu primer servicio.";


    // Conversacion Escena 3
    public string Escena3_dialoge_1 = "Bienvenido a Amodoro Maid Café. ¿Qué desea pedir amo?";
    public string Escena3_dialoge_2 = "¡Hola, mi nombre es Yoshiro, un gusto conocerte!";
    public string Escena3_dialoge_3 = "...";
    public string Escena3_dialoge_4 = "¿Qué me recomiendas? Seguro que tienes muy buen gusto.";
    public string Escena3_dialoge_5 = "La verdad es que es mi primer día, aún no estoy familiarizada con todo lo del menú, pero estoy segura de que sea lo que sea que pidas va a estar muy rico.";
    public string Escena3_dialoge_6;
    public string Escena3_dialoge_7 = "¿Podrías traerme una caja de harina cuando acabes con ese cliente, por favor? Está en el almacén.";
    public string Escena3_dialoge_8 = "Muchas gracias preciosa.";


    //Conversacion 1 Escena 6 

    public string Escena6_dialoge_1 = "Hola, soy Usagi, empecé a trabajar ayer. Ayane no me había dicho nada de otra compañera.";
    public string Escena6_dialoge_2 = "Puede ser que se le olvidara, he tenido que estar ausente. Por cierto, me llamo\r\nKyoko. Yo estoy en el escenario haciendo los shows. ¿Qué te ha parecido tu primer día?";
    public string Escena6_dialoge_3 = "Todo bien, ha sido más tranquilo de lo que me esperaba, aunque Ayane tiene razón y hay algunos clientes extraños.";
    public string Escena6_dialoge_4 = "Con el tiempo te acostumbrarás. Ayer de hecho vino un amigo mío a tomar algo, probablemente lo atendiste, se llama Yoshiro, es muy buena gente cuando lo conoces bien.";
    public string Escena6_dialoge_5 = "Ahh… si… Sí que lo atendí, seguro que se ve buena gente…";
    public string Escena6_dialoge_6 = "Veo que vosotras dos ya os habéis conocido. ¿Lista para otro día de esclavitud, Usagi? Bien pues a cambiarse que tenemos que empezar el servicio.";
    public string Escena6_dialoge_7 = "Ja, ja… Muy graciosa, Ayane.";

    //Conversacion 2 Escena 6 

    public string Escena6_dialoge_8 = "Veo que no me has querido escribir… No pasa nada guapa, para que no te de vergüenza te traje un pequeño regalito.";
    public string Escena6_dialoge_9 = "No creo que sea correcto aceptar regalos de mis clientes.";
    public string Escena6_dialoge_10 = "No te preocupes, pero a la próxima puedes escribirme sin miedo guapa.";
    public string Escena6_dialoge_11 = "¿Qué quieres pedir, mi señor?";
    public string Escena6_dialoge_12 = "Quiero una MofuMofu Carrot y dos botellas de agua por favor, preciosa.";
    public string Escena6_dialoge_13 = "Enseguida. Nos vamos detrás del mostrador y le pasamos las ordenes a Ayane.";
    public string Escena6_dialoge_14 = "¿Podrías traerme una caja de huevos del depósito cuando termines allí, por favor?\r\nHoy el día está más ajetreado que ayer.";

    void Start()
    {
        tipo_1 = X + Y + Z +"por favor.";

        tipo_1 = "Has tardado mucho. Me gustaría" + X + Y + Z;

        Escena3_dialoge_6 = "Pues ponme" + X + Y + Z + ", por favor preciosa.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
