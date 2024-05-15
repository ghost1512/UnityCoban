using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Bat dau va cham");
        Debug.Log(collision.gameObject.name);
    }
    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log("Va cham");
    }
    private void OnCollisionExit(Collision collision)
    {
        //Debug.Log("Thoat va cham");
    }
    private void OnTriggerEnter(Collider other)
    {
       // Debug.Log("Bat dau va cham TRIGGER");
        Debug.Log(other.name);
    }
    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("Va cham TRIGGER");
    }
    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Thoat va cham TRIGGER");
    }
}
