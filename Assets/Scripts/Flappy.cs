using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    [SerializeField] float velocidad = 2;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocidad;
            SonidosManager.instance.ReproducirSonido(SonidosManager.instance.sonido_Flap);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SonidosManager.instance.ReproducirSonido(SonidosManager.instance.sonido_Muerte);
        FindAnyObjectByType<GameManager>().GameOver();
    }
}
