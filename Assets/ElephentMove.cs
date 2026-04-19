using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElephentMove : MonoBehaviour
{
    public Transform tam;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(tam);
        transform.position = Vector3.Lerp(transform.position, tam.position, speed * Time.deltaTime);
    }
}
