using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    public float speedMove = 20;
    public float speedRotate = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, vertical * speedMove * Time.deltaTime));
        transform.Rotate(0f, horizontal * speedRotate * Time.deltaTime, 0f);
    }
}
