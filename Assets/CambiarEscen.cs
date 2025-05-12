using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscen : MonoBehaviour
{
    public void IrAlMenu()
    {
        SceneManager.LoadScene("MenuPrincipal"); // Asegúrate que el nombre sea exacto
    }
}
