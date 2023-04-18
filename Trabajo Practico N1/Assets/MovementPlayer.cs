using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{

    float speed = 5f;
    private string nombre ="Pedro";

    
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }



private void Start()
    {
        
    }


    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3 (horizontalInput, 0, verticalInput);
        transform.position = transform.position + movementDirection * speed * Time.deltaTime;
    }

}