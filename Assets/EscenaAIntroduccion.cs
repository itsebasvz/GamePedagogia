using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaAIntroduccion : MonoBehaviour
{
    public void IrAlMenu()
    {
        SceneManager.LoadScene("02"); // Aseg�rate que el nombre sea exacto
    }
}