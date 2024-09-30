using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public GameObject projectilePrefab; // Prefab do projétil
    public Transform FirePoint;
    public float fireRate = 2f; // Taxa de tiro em segundos

    private IEnumerator fireCoroutine; 

    void Start()
    {
        
    }  

    void OnTriggerStay(Collider other)  
    {
        if (other.gameObject.CompareTag("Player") && fireCoroutine == null)
        {
            fireCoroutine = Shoot();
            StartCoroutine(fireCoroutine);
        }
    }

    private IEnumerator Shoot()
    {
        while (true) // Loop infinito para continuar atirando
        {            
            FireProjectile();
            yield return new WaitForSeconds(fireRate); // Espera a quantidade de segundos definida em fireRate
        }
    }

    private void FireProjectile()
    {
        // Instancia o projétil na posição do firePoint
        Instantiate(projectilePrefab, FirePoint.position, FirePoint.rotation);
    }

}
