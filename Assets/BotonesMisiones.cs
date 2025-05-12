using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesMisiones : MonoBehaviour
{
    public void IrAMision1()
    {
        SceneManager.LoadScene("Mision1"); // Asegúrate que el nombre sea exacto
    }

    public void IrAMision2()
    {
        SceneManager.LoadScene("Mision2"); // Asegúrate que el nombre sea exacto
    }
}



