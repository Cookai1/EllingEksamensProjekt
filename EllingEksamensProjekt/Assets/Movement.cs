using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController myCC;

    public float moveSpeed;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        myCC = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        BasicMovement();
    }

    void BasicMovement()
    {
        if(Input.GetKey(KeyCode.W))
        {
            myCC.Move(transform.forward * Time.deltaTime * moveSpeed);

        }

        if (Input.GetKey(KeyCode.S))
        {
            myCC.Move(-transform.forward * Time.deltaTime * moveSpeed);

        }

        if (Input.GetKey(KeyCode.D))
        {
            myCC.Move(-transform.right * Time.deltaTime * moveSpeed);

        }

        if (Input.GetKey(KeyCode.D))
        {
            myCC.Move(transform.right * Time.deltaTime * moveSpeed);

        }
    }

    void BasicRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * rotationSpeed;
        transform.Rotate(new Vector3(0, mouseX, 0));
    }
}

