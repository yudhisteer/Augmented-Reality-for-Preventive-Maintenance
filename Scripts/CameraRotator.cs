using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float x = Input.GetAxis("Mouse X");
            if(x > 0)
            {
                transform.Rotate(0f, speed * Time.deltaTime, 0f);
            }
            if (x < 0)
            {
                transform.Rotate(0f, -speed * Time.deltaTime, 0f);
            }
        }
    }
}
