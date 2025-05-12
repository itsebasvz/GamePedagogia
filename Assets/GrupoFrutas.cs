using UnityEngine;
using UnityEngine.EventSystems;

public class GrupoFrutas : MonoBehaviour, IPointerClickHandler
{
    public int cantidadFrutas; // Se asigna en el Inspector
    public JuegoComparacion juegoManager; // Se asigna en el Inspector o desde Start()

    public void OnPointerClick(PointerEventData eventData)
    {
        juegoManager.ValidarSeleccion(this);
    }
}
