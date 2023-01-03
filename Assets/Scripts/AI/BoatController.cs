using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    public static BoatController Instance;
    public GameObject player; 
    public float flag;
    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //set not static to translate 

        //var tsl = Mathf.Sin((2f * Mathf.PI / (5.0f * Time.deltaTime)))*30.0f;
        //var tsl1 = Mathf.Sin(((5.0f * Time.deltaTime))*Mathf.Rad2Deg - 90) * 30.0f;
        //Debug.Log(Mathf.Sin(Time.deltaTime * Mathf.Rad2Deg - 90));

        //transform.Translate(new Vector3(0, 0, tsl1),  Space.World);
        //Debug.Log(transform.forward);
        //Debug.Log(transform.position.z);
        // 0,0,-1
        if(transform.position.z > 310.0f) flag = 1;
        else if(transform.position.z < 295.0f) flag = -1;
        transform.position += transform.forward*flag * Time.deltaTime;
        //if(PlayerController.Instance.check) PlayerController.Instance.transform.position += transform.forward * flag * Time.deltaTime;
    }
}
