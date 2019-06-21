using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour

{
    public Transform Car_transform;
    public GameObject Car;
    public float speed=1f;
    private Vector3 force_car;
    private Animator flight_anmation;

    // Start is called before the first frame update
    void Start()
    {
        flight_anmation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Car_transform.position  += force_car;

        if (Input.GetKey(KeyCode.W))
        {
            flight_anmation.Play("spaceship2");
            force_car -= (Car_transform.up * Time.deltaTime) * 0.01f;
        }
        else {
            flight_anmation.Play("Space2_stay");
            force_car = Vector3.Lerp(force_car, Vector3.zero, Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            force_car += (Car_transform.up * Time.deltaTime) * 0.001f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Car_transform.Rotate(0,0,2);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Car_transform.Rotate(0, 0, -2);
        }
        
    }

}
