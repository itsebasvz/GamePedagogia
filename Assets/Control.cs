using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public void RegresarAEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}

