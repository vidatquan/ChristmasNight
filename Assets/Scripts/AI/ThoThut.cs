using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class ThoThut : MonoBehaviour
{
    public static ThoThut Instance;
    public float flag;
    private void Awake()
    {
        Instance = this;
    }
    private static int StrBiome()
    {
        return Random.Range(1, 6);
    }

    // Start is called before the first frame update
    void Start()
    {
        flag = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("tho thut:"+transform.position);
        if (transform.position.x > -302.0f) flag = 1;
        else if (transform.position.x < -318.0f) flag = -1;
        var rd = StrBiome();
        //Debug.Log("rd :" + rd);
        transform.position += new Vector3(-rd, 0, 0) * flag * Time.deltaTime;
        //if (PlayerController.Instance.check) PlayerController.Instance.transform.position += new Vector3(-rd, 0, 0) * flag * Time.deltaTime;
    }
}
