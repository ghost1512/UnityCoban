using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    //Public
    public float maxHealth = 100;
    public float speedMove = 20f;
    public float speedRotate = 100f;
    public float fuelValue = 20;
    public float damdgeValue = 50;
    public GameObject explustionPrefabs;

    //Private
    private float currenHealth = 0;
    // Start is called before the first frame update
    void Start()
    {
        currenHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, vertical * speedMove * Time.deltaTime));
        transform.Rotate(new Vector3(0, horizontal * speedRotate * Time.deltaTime, 0));
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "fuel" )
        {
            Destroy(other.gameObject);
            GameManager.instance.SetFuel(fuelValue);
            InstantiateGame(other);
        }
        else if(other.tag == "damage")
        {
            DamageHealth(damdgeValue);
            InstantiateGame(other);
        }
    }
    void InstantiateGame(other)
    {
        Instantiate(explustionPrefabs, other.transform.position, Quaternion.identity);
    }
    private void DamageHealth(float health)
    {
        if(currenHealth > 0)
        {
            currenHealth -= health;
        }
        else
        {
            currenHealth = 0;
            Destroy(gameObject);
        }
    }
}   
