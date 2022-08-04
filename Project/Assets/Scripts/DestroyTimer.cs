using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    [SerializeField] float timer;

    void Start()
    {
        StartCoroutine(Die());
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(timer);

        Destroy(gameObject);
    }
}
