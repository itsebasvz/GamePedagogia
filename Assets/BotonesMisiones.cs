using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesMisiones : MonoBehaviour
{
    public void IrAMision1()
    {
        SceneManager.LoadScene("Mision1"); // Aseg�rate que el nombre sea exacto
    }

    public void IrAMision2()
    {
        SceneManager.LoadScene("Mision2"); // Aseg�rate que el nombre sea exacto
    }
}



