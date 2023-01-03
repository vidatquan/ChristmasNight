using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class elevator : MonoBehaviour
{
    public static elevator Instance;
    public float flag;
    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        flag = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 10.0f) flag = -1;
        else if (transform.position.y < 0.0f) flag = 1;
        transform.position += new Vector3(0, 4, 0) * flag * Time.deltaTime;
        //if (PlayerController.Instance.check) PlayerController.Instance.transform.position += new Vector3(0, 4, 0) * flag * Time.deltaTime;

    }
}
