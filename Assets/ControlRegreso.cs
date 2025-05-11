using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlRegreso : MonoBehaviour
{
    public void IrATres()
    {
        SceneManager.LoadScene("03"); // Asegúrate que el nombre sea exacto
    }
    public void IrAMision2()
    {
        SceneManager.LoadScene("Mision2"); // Asegúrate que el nombre sea exacto
    }
}
