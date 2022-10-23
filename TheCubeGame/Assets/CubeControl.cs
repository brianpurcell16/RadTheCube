using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{

    public Transform cubeTemplate;

    Rigidbody ourRigidBody;

    private float turningSpeed = 180;
    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
            transform.position += transform.forward * 2 * Time.deltaTime ;

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position += Vector3.left * 2 * Time.deltaTime;

        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += Vector3.right * 2 * Time.deltaTime;

        if (Input.GetKey(KeyCode.DownArrow))
            transform.position -= transform.forward * 2 * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ourRigidBody.AddExplosionForce(300, transform.position + Vector3.down, 2);
        }





        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -turningSpeed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.up, -turningSpeed * Time.deltaTime);

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(cubeTemplate,transform.position - transform.forward, Quaternion.identity);
        }

    }
}
