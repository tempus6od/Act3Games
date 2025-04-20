using UnityEditor;
using UnityEngine;

public class SpawnerTuberias : MonoBehaviour
{
    [SerializeField] GameObject prefabTuberia;
    [SerializeField] float rangoDeAltura = 0.5f;
    [SerializeField] float tiempoSpawn = 1.7f;

    private float timer;

    private void Start()
    {
        SpawnearTuberia();
    }


    private void Update()
    {
        timer += Time.deltaTime; // Crear contador

        if (timer > tiempoSpawn)
        {
            SpawnearTuberia();
            timer = 0; // Reinicia contador
        }
    }
    private void SpawnearTuberia()
    {
        Vector3 altura = new Vector3(0, Random.Range(-rangoDeAltura, rangoDeAltura));
        GameObject tuberia = Instantiate(prefabTuberia, transform.position + altura, Quaternion.identity);
        Destroy(tuberia, 15); //Destruye tuberia luego de 15 seg
    }
}
