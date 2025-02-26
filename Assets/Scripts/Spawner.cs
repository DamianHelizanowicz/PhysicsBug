using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    private void Start()
    {
        Instantiate(prefab, new Vector3(-1.0f, 1.5f, 0.0f), Quaternion.identity, transform);
    }
}