using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorRegresar : MonoBehaviour
{
    public void IrAlMenu()
    {
        SceneManager.LoadScene("MenuPrincipal"); // Aseg�rate que el nombre sea exacto
    }
}

