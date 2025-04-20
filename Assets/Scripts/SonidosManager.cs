using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosManager : MonoBehaviour
{
    public static SonidosManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);

        }
        else

        {
            instance = this;
        }
    }

    [SerializeField] AudioSource sonidos;

    [SerializeField] public AudioClip sonido_Flap;
    [SerializeField] public AudioClip sonido_Muerte;
    [SerializeField] public AudioClip sonido_Punto;

    public void ReproducirSonido(AudioClip clip)
    {
        sonidos.PlayOneShot(clip);
    }
}
