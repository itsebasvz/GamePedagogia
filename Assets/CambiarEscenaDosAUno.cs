using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaDosAUno : MonoBehaviour
{
    public void IrAlMenu()
    {
        SceneManager.LoadScene("MenuPrincipal"); // Asegúrate que el nombre sea exacto
    }
}
