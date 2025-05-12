using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JuegoSecuenciaSimple : MonoBehaviour
{
    // Start is called before the first frame update

    // Imagen de referencia (3 manzanas)
    public Image maestra;
    public Image nubeTexto;
    public Image imagen3Manzanas;
    public Text textoPregunta;

    // Botones con im�genes de 4 y 6 manzanas
    public Button botonIzquierdo; // Opci�n correcta (4 manzanas)
    public Button botonDerecho;   // Opci�n incorrecta (6 manzanas)

    // Sprites de las manzanas
   //public Sprite manzanas3;
   //public Sprite manzanas4;
   //public Sprite manzanas6;

    // Panel de resultado
    public GameObject panelResultado;
    public Text textoResultado;
    public Button botonIntentarDeNuevo;
    public Button botonCerrar;
    public Image imagenNube;
    void Start()
    {
        IniciarPregunta();
    }

    void IniciarPregunta()
    {
        panelResultado.SetActive(false);

       // imagenPregunta.sprite = manzanas3;
       // textoPregunta.text = "�Qu� n�mero viene despu�s del 3?";

       // botonIzquierdo.image.sprite = manzanas4;
       // botonDerecho.image.sprite = manzanas6;

        botonIzquierdo.onClick.RemoveAllListeners();
        botonDerecho.onClick.RemoveAllListeners();
        botonIntentarDeNuevo.onClick.RemoveAllListeners();
        botonCerrar.onClick.RemoveAllListeners();

        botonIzquierdo.onClick.AddListener(() => Evaluar(true));
        botonDerecho.onClick.AddListener(() => Evaluar(false));
    }

    void Evaluar(bool esCorrecta)
    {
        panelResultado.SetActive(true);

        if (esCorrecta)
        {
            textoResultado.text = "�Muy bien! El n�mero que sigue al 3 es el 4.";
            botonIntentarDeNuevo.gameObject.SetActive(false);
            botonCerrar.gameObject.SetActive(true);
            botonCerrar.onClick.AddListener(IniciarPregunta);
        }
        else
        {
            textoResultado.text = "Intenta de nuevo. �T� puedes!";
            botonIntentarDeNuevo.gameObject.SetActive(true);
            botonCerrar.gameObject.SetActive(false);
            botonIntentarDeNuevo.onClick.AddListener(IniciarPregunta);
        }
    }

}
