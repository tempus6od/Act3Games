using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoPuntaje;
    [SerializeField] TextMeshProUGUI textoMejorPuntaje;

    private int puntaje;

    private void Start()
    {
        textoMejorPuntaje.text = puntaje.ToString();
        textoMejorPuntaje.text = PlayerPrefs.GetInt("MejorPuntaje", 0).ToString();
        //Obtiene el mejor puntaje guardado previamente usando PlayerPrefbs
        // si no hay mejor puntaje guardado, utiliza 0 vcomo valor por defecto
    }

    public void GuardarMejorPuntaje()
    {
        if(puntaje > PlayerPrefs.GetInt("MejorPuntaje"))
        {
            PlayerPrefs.SetInt("MejorPuntaje", puntaje);
            textoMejorPuntaje.text = puntaje.ToString();
        }
    }

    public void AumentarPuntaje()
    {
        puntaje++;
        textoPuntaje.text = puntaje.ToString();
        GuardarMejorPuntaje();
    }
}
