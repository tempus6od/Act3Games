using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Tuberias : MonoBehaviour
{
    [SerializeField] float velocidad = 0.75f;
    [SerializeField] GameObject aplauso;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * velocidad * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            aplauso.gameObject.SetActive(false);
            FindAnyObjectByType<Puntaje>().AumentarPuntaje();
            SonidosManager.instance.ReproducirSonido(SonidosManager.instance.sonido_Punto);
        }
    }
}
