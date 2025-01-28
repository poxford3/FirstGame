using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {

        Vector3 movementDirection = new(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        transform.Translate(speed * Time.deltaTime * movementDirection.normalized);

    }
}
