using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.TimeZoneInfo;
using UnityEngine.SceneManagement;

public class QuaiVat : MonoBehaviour
{
    public Animator transition;
    public GameObject player;
    public Vector3 tf;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 tf = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (player.transform.position.x < -320.0f && player.transform.position.z > 230.0f && player.transform.position.y > -4.0f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 1 * Time.deltaTime);
            transform.position += transform.forward * 3.0f * Time.deltaTime;
        }
        else
        {
            Vector3 hardFix = new Vector3(-371.81f, -1.16f, 273.68f);
            Quaternion targetRotation = Quaternion.LookRotation(hardFix - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 1 * Time.deltaTime);
            transform.position += transform.forward * 3.0f * Time.deltaTime;
        }
        if (distance < 15.0f)
        {
            StartCoroutine(Attack());
        }
    }

    IEnumerator Attack()
    {
        Debug.Log("attack");
        //play animation
        transition.SetTrigger("Attack");
        //wait
        yield return new WaitForSeconds(1);

    }


}
