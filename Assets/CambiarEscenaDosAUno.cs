using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaDosAUno : MonoBehaviour
{
    public void IrAlMenu()
    {
        SceneManager.LoadScene("MenuPrincipal"); // Aseg�rate que el nombre sea exacto
    }
    public void IrAIntroduccion()
    {
        SceneManager.LoadScene("Introduccion2"); // Aseg�rate que el nombre sea exacto
    }
}
