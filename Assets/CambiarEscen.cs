using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscen : MonoBehaviour
{
    public void IrAlMenu()
    {
        SceneManager.LoadScene("MenuPrincipal"); // Aseg�rate que el nombre sea exacto
    }
}
