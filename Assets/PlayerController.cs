using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float playerMoveSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 pos = Vector3.zero;
        pos.x = Input.GetAxis("Horizontal") * playerMoveSpeed;
        pos.z = Input.GetAxis("Vertical") * playerMoveSpeed;

        this.transform.position = pos;
    }
}
