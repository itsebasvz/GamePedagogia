using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ZonaDrop : MonoBehaviour, IDropHandler
{
    public int cantidadCorrecta; // Número que debe coincidir
    public Text feedbackText;
    public void OnDrop(PointerEventData eventData)
    {
        feedbackText.text = "Se soltó un número";

        if (eventData.pointerDrag != null)
        {
            feedbackText.text += "\nObjeto soltado: " + eventData.pointerDrag.name;

            NumeroDraggable numero = eventData.pointerDrag.GetComponent<NumeroDraggable>();

            if (numero != null)
            {
                feedbackText.text += "\nNúmero detectado: " + numero.numero;

                if (numero.numero == cantidadCorrecta)
                {
                    feedbackText.text = "¡Muy bien!";
                }
                else
                {
                    feedbackText.text = "Sigue intentando. ¡Tú puedes!";
                }
            }
            else
            {
                feedbackText.text += "\n(No tiene componente NumeroDraggable)";
            }
        }
        else
        {
            feedbackText.text += "\n(eventData.pointerDrag es null)";
        }
    }

}
