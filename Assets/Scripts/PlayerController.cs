using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3.5f;

    private float gravity = 10f;




    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButton("Fire1"))
        {
            playerMovement();
        }
    }

    void playerMovement()
    {
        transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
    }
}
