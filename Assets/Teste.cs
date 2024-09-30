using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    public float speed = 10f; // Velocidade do projétil
    public float lifetime = 2f; // Tempo de vida do projétil

    private void Start()
    {
        Destroy(gameObject, lifetime); // Destrói o projétil após um tempo
    }

    private void Update()
    {
        // Move o projétil para frente
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

}