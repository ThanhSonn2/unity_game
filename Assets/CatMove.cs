using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMove : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(new Vector3(0,-90, 0) * speed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(new Vector3(0, 90, 0) * speed * Time.deltaTime);
    }
}
