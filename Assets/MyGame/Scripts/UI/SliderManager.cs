using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    [SerializeField]
    private Slider mySlider;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(mySlider.minValue);
        Debug.Log(mySlider.maxValue);
        mySlider.value = 5;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(mySlider.value );
    }
    public void OnValueChangSlider()
    {
        Debug.Log("Da co gia tri thay doi");
    }
}
