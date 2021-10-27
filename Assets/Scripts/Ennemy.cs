using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    private Transform ennemyTransform { get; set; } = null;

    private float speed { get; set; } = 2.0f;

    void Start()
    {
        ennemyTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        ennemyTransform.position += Vector3.forward * Time.deltaTime;
    }
}
