using UnityEngine;
using UnityEngine.SceneManagement;

public class RegresarInicio : MonoBehaviour
{
    public void IrAlMenu()
    {
        SceneManager.LoadScene("PantallaInicio"); // Aseg�rate que el nombre sea exacto
    }
}
