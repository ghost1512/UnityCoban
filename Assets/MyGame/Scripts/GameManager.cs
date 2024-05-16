using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float fuel = 0;
    public int roundNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void SetFuel(float fuel)
    {
        this.fuel += fuel;
    }
    public void SetRound(int roundNumber)
    {
        this.roundNumber += roundNumber;
    }
}
