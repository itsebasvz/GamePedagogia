using UnityEngine;
using UnityEngine.EventSystems;

public class FruitDropZone : MonoBehaviour, IDropHandler
{
    [SerializeField] private int requiredNumber; // N�mero que debe coincidir (ej: 3)

    public void OnDrop(PointerEventData eventData)
    {
        // Obtiene el n�mero arrastrado
        GameObject droppedNumber = eventData.pointerDrag;
        DraggableNumber numberScript = droppedNumber.GetComponent<DraggableNumber>();

        if (numberScript != null)
        {
            int numberValue = int.Parse(droppedNumber.name); // El nombre del GameObject debe ser "1", "2", etc.

            if (numberValue == requiredNumber)
            {
                Debug.Log("�Correcto! N�mero " + numberValue + " en la zona " + requiredNumber);
                // Efectos de acierto (sonido, animaci�n)
                GetComponent<SpriteRenderer>().color = Color.green; // Cambia color temporal (debug)
            }
            else
            {
                Debug.Log("Incorrecto. Intenta de nuevo.");
                numberScript.ReturnToOriginalPosition(); // Vuelve a su posici�n
            }
        }
    }
}
