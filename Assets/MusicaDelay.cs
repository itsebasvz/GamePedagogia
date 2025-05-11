using UnityEngine;

public class ReproducirConDelay : MonoBehaviour
{
    public float delay = 2f; // Puedes ajustar esto desde el Inspector

    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.PlayDelayed(delay);
    }
}

