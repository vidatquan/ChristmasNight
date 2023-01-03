using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class FishController : MonoBehaviour
{
    private float flag = -1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -402.0f)
        {
            flag = 1;
            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
            //transform.Rotate(0.0f, 180.0f, 0.0f, Space.World);
        }
        else if (transform.position.x > -377.0f) { 
            flag = -1;
          //  transform.Rotate(0.0f, 180.0f, 0.0f, Space.World);
             transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        transform.position += new Vector3(1, 0, 0) * flag * Time.deltaTime;
    }
}
