using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EdadSelector : MonoBehaviour
{
    public GameObject panelConfirmacion;
    public Text textoConfirmacion; // arr�stralo desde el Inspector
    private int edadTemporal;

    public void SeleccionarEdad(int edad)
    {
        edadTemporal = edad;
        panelConfirmacion.SetActive(true);

        string mensaje;

        if (edadTemporal == 1)
        {
            mensaje = "�Tienes 1 a�o?";
        }
        else
        {
            mensaje = $"�Tienes {edadTemporal} a�os?";
        }

        textoConfirmacion.text = mensaje;
    }

    public void ConfirmarEdad()
    {
        PlayerPrefs.SetInt("Edad", edadTemporal);
        Debug.Log("Edad confirmada: " + edadTemporal);
        SceneManager.LoadScene("Mision1");
        // Aqu� puedes cargar otra escena o continuar
        // SceneManager.LoadScene("SiguienteEscena");
    }

    public void CancelarConfirmacion()
    {
        panelConfirmacion.SetActive(false);
    }
}
