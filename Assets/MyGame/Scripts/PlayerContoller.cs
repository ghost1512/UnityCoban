using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    // Public
    public float maxHealth = 100;
    public float speedMove = 20f;
    public float speedRotate = 100f;
    public float fuelValue = 20;
    public float damageValue = 50;
    public GameObject explosionPrefabs;
    public int roundValue = 0;
    // Private
    private float currentHealth;
    private Rigidbody rb;
    private bool isGate = false;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        rb = GetComponent<Rigidbody>();
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
        if (other.tag == "fuel")
        {
            Destroy(other.gameObject);
            GameManager.instance.SetFuel(fuelValue);
            InstantiateGame(other.gameObject);
        }
        else if (other.tag == "damege")
        {
            Destroy(other.gameObject);
            DamageHealth(damageValue);
            InstantiateGame(other.gameObject);
        }
        else if (other.tag == "FinishGame")
        {
            if(isGate == true)
            {
                GameManager.instance.SetRound(roundValue);
                isGate = false;
            }
        }
       if (other.name == "Gate")
        {
            isGate = true;
        }
    }

    void InstantiateGame(GameObject other)
    {
        Instantiate(explosionPrefabs, other.transform.position, Quaternion.identity);
    }

    private void DamageHealth(float health)
    {
        if (currentHealth > 0)
        {
            currentHealth -= health;
        }
        else
        {
            currentHealth = 0;
            Destroy(gameObject);
        }
    }
}
