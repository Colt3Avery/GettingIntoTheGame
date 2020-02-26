using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 10.0f;
    // variable to make boundary to 10, so someone else can read our code better
    const float hozBoundary = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // stops player from moving past 10 in positive (right)
       if(transform.position.x > hozBoundary)
        {
            transform.position = new Vector3(hozBoundary, transform.position.y, transform.position.z);
        }
        // stops player from moving past -10 (left)
        if (transform.position.x < -hozBoundary)
        {
            transform.position = new Vector3(-hozBoundary, transform.position.y, transform.position.z);
        }

        float Hmove = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Hmove * Time.deltaTime * speed);
    }
}
