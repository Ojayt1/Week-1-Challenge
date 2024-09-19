using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 0.7f;
    public float rotationSpeed;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        forwardInput = Input.GetAxis("Vertical");
        

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
    
        transform.Rotate (Vector3.left * Time.deltaTime * rotationSpeed * forwardInput);
      ;

    }
}
