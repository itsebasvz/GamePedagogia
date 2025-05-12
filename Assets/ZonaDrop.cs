using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ZonaDrop : MonoBehaviour, IDropHandler
{
    public int cantidadCorrecta; // N�mero que debe coincidir
    public Text feedbackText;
    public void OnDrop(PointerEventData eventData)
    {
        feedbackText.text = "Se solt� un n�mero";

        if (eventData.pointerDrag != null)
        {
            feedbackText.text += "\nObjeto soltado: " + eventData.pointerDrag.name;

            NumeroDraggable numero = eventData.pointerDrag.GetComponent<NumeroDraggable>();

            if (numero != null)
            {
                feedbackText.text += "\nN�mero detectado: " + numero.numero;

                if (numero.numero == cantidadCorrecta)
                {
                    feedbackText.text = "�Muy bien!";
                }
                else
                {
                    feedbackText.text = "Sigue intentando. �T� puedes!";
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
