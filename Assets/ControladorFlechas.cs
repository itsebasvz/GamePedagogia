using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorFlechas : MonoBehaviour
{
    public void IrAMision1()
    {
        SceneManager.LoadScene("Mision1"); // Aseg�rate que el nombre sea exacto
    }

    public void IrAMision3()
    {
        SceneManager.LoadScene("Mision3"); // Aseg�rate que el nombre sea exacto
    }
}
