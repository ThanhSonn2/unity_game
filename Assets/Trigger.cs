using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Collider = đi xuyên vật thể, hay đi vào vùng
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            Debug.Log("----GAME OVER-----");
            //Destroy(other.gameObject);
        }
    }
    //Collision = va chạm vật thể
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            Debug.Log("----GAME OVER-----");
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("Dang o trong vung cam " + other.name);
    }

    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log("Dang cham vao " + collision.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Thoat khoi vung cam " + other.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Khong con cham vao " + collision.gameObject.name);
    }
}
