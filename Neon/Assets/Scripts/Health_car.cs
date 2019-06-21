using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_car : MonoBehaviour
{
    public GameObject Car;
    public GameObject lose_panel;
    public int health_car;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        health_car = 100;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = health_car;
        if (health_car == 0) { Destroy(Car); lose_panel.SetActive(true) ; }
  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("enter");
        health_car -= 1;
    }
    private void Destroy()
    {
        Destroy(Car, .5f);
    }
}
