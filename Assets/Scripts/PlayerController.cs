using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0F;
    public float turnSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vamos a mover el vehículo hacia adelante
        //transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
    }
}
