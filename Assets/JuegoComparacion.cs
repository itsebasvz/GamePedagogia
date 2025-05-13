using UnityEngine;
using UnityEngine.UI;

public class JuegoComparacion : MonoBehaviour
{
    public GrupoFrutas grupo1;         // Arrástralo desde el Inspector
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
        // Determinar cuál es el otro grupo
        GrupoFrutas otro = (seleccionado == grupo1) ? grupo2 : grupo1;

        // Comparar cantidades
        if (seleccionado.cantidadFrutas > otro.cantidadFrutas)
        {
            feedbackText.text = "¡Genial! Estoy muy orgullosa de ti. " +
                "¡Que la magia de los números te acompañe siempre!";
        }
        else
        {
            feedbackText.text = "Inténtalo otra vez. ¡Tú puedes!";
        }
    }

}