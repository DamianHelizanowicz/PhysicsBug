using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private float spawnDelay = -1.0f;
    [SerializeField] private float attachDelay = 2.0f;

    private void Start()
    {
        if (spawnDelay < 0)
        {
            Instantiate(prefab, new Vector3(1.0f, 1.5f, 0.0f), Quaternion.identity, transform);
        }
        else
        {
            StartCoroutine(SpawnAfterDelay(spawnDelay));
        }

        StartCoroutine(AttachAfterDelay(attachDelay));
    }

    private IEnumerator AttachAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        foreach (JointController controller in FindObjectsOfType<JointController>())
            controller.Attach();

    }

    private IEnumerator SpawnAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        Instantiate(prefab, new Vector3(1.0f, 1.5f, 0.0f), Quaternion.identity, transform);
    }
}