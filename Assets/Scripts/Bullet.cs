using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] Transform monkey;
    [SerializeField] GameObject explosion;
    [SerializeField] float speed;
    Rigidbody rd;

    
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
        Vector3 targetVec = monkey.transform.position - transform.position;
        targetVec.Normalize();
        rd.velocity = targetVec * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject,0.1f);
        Instantiate(explosion,transform.position+(Vector3.back* 3.0f),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
           
    }
}
