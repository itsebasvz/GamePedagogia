using UnityEngine;
using UnityEngine.UI;

public class JuegoComparacion : MonoBehaviour
{
    public GrupoFrutas grupo1;         // Arr�stralo desde el Inspector
    public GrupoFrutas grupo2;         // Igual
    public Text feedbackText;          // Texto UI para mostrar el resultado

    void Start()
    {
        // Establecer este manager como referencia en los grupos
        grupo1.juegoManager = this;
        grupo2.juegoManager = this;
    }

    public void ValidarSeleccion(GrupoFrutas seleccionado)
    {
        // Determinar cu�l es el otro grupo
        GrupoFrutas otro = (seleccionado == grupo1) ? grupo2 : grupo1;

        // Comparar cantidades
        if (seleccionado.cantidadFrutas > otro.cantidadFrutas)
        {
            feedbackText.text = "�Genial! Estoy muy orgullosa de ti. " +
                "�Que la magia de los n�meros te acompa�e siempre!";
        }
        else
        {
            feedbackText.text = "Int�ntalo otra vez. �T� puedes!";
        }
    }

}