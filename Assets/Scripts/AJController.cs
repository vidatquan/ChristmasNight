using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AJController : MonoBehaviour
{
    public Animator animator;
    public bool run = false;

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            Debug.Log("alo");
            StartCoroutine(OpenCloseTrap());
        }*/
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) ||
            Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            run = true;
            StartCoroutine(Run());
        }
        else if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D) ||
            Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            run = false;
            StartCoroutine(Run());
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Jumping", true);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("Jumping", false);
        }

        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) ||
            Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) 
            && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
        {
            animator.SetBool("FastRun", true);
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
        {
            animator.SetBool("FastRun", false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            animator.SetBool("Dancing", true);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            animator.SetBool("Dancing", false);
        }

    }

    IEnumerator Run()
    {
        animator.SetBool("Running", run);
        yield return new WaitForSeconds(1);
    }
}
