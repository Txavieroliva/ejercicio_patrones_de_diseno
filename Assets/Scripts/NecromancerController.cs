using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NecromancerController : MonoBehaviour
{
    public GameObject skeletonPrefab;  // Prefab del esqueleto
    private SkeletonFactory _skeletonFactory;  // Fábrica de esqueletos
    private List<GameObject> summonedSkeletons = new List<GameObject>();  // Lista de esqueletos creados

    private void Start()
    {
        _skeletonFactory = new BasicSkeletonFactory(skeletonPrefab);  // Crear la fábrica con el prefab
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SummonSkeleton();  // Invocar esqueletos al presionar E
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            DestroyAllSkeletons();  // Destruir todos los esqueletos al presionar R
        }
    }

    private void SummonSkeleton()
    {
        // Crear un nuevo esqueleto en una posición determinada y agregarlo a la lista
        GameObject skeleton = _skeletonFactory.CreateSkeleton(transform.position + transform.forward * 2);
        summonedSkeletons.Add(skeleton);  // Guardamos el esqueleto en la lista
    }

    private void DestroyAllSkeletons()
    {
        // Recorrer la lista de esqueletos y destruir cada uno
        foreach (GameObject skeleton in summonedSkeletons)
        {
            Destroy(skeleton);  // Destruir el esqueleto
        }

        // Limpiar la lista después de destruir los esqueletos
        summonedSkeletons.Clear();
    }
}
