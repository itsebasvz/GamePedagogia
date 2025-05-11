using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaAIntroduccion : MonoBehaviour
{
    public void IrAlMenu()
    {
        SceneManager.LoadScene("02"); // Asegúrate que el nombre sea exacto
    }
}