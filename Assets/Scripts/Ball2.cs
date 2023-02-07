using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball2 : MonoBehaviour
{
    Rigidbody rd;
    [SerializeField] private float firstPow = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
        rd.velocity= Vector3.right * firstPow; // xç¿ïWÇ™1
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            /*
            rd.AddForce(Vector3.up * 20.0f ,ForceMode.Acceleration);// x0 y1 z0
            */

            rd.velocity = Vector3.up * 20.0f;
        }
    }
}
