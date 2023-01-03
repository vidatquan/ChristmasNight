using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    public float Health;
    public bool check;
    public bool checkFire;
    public GameObject blood;

    /*public GameObject conver;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("santa") || other.gameObject.CompareTag("villager"))
        {
            Debug.Log("player trigger");
            conver.SetActive(true);
            FindObjectOfType<DialogManger>().StartDialogue(dialogue, 1);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("1");
            conver.SetActive(false);
        }
    }*/
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        Health = 100;       
    }

    private void Update()
    {
        if (transform.position.y < -6.1f)
        {
            TextMeshProUGUI healthText = GameObject.Find("HealthText").GetComponent<TextMeshProUGUI>();
            Health -= 1;
            //BloodController.Instance.LoadBlood();
            healthText.text = Health.ToString() + "/100";
            if (Health < 1)
            {
                Health = 0;
                healthText.text = Health.ToString() + "/100";
                checkDead();
               // FuncBlood();

                return;
            }
            checkDead();
           // FuncBlood();

        }
    }
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("quaivat"))
        {
            TextMeshProUGUI healthText = GameObject.Find("HealthText").GetComponent<TextMeshProUGUI>();
            Health -= 20;

            if (Health < 1) Health = 0;  
            checkDead();
           
            healthText.text = Health.ToString() + "/100";
            FuncBlood();


        }
        else if(other.gameObject.CompareTag("spike"))
        {
            TextMeshProUGUI healthText = GameObject.Find("HealthText").GetComponent<TextMeshProUGUI>();

            Health -= 5;

            if (Health < 1) Health = 0;
            checkDead();
            FuncBlood();


            healthText.text = Health.ToString() + "/100";
        }
        else if (other.gameObject.CompareTag("fire"))
        {
            checkFire = true;
            TextMeshProUGUI healthText = GameObject.Find("HealthText").GetComponent<TextMeshProUGUI>();

            StartCoroutine(DelayFire(healthText));
        }
        else if (other.gameObject.CompareTag("maychem"))
        {
            TextMeshProUGUI healthText = GameObject.Find("HealthText").GetComponent<TextMeshProUGUI>();

            Health -= 8;

            if (Health < 1) Health = 0;
            checkDead();
            healthText.text = Health.ToString() + "/100";
            FuncBlood();

        }

        else if (other.gameObject.CompareTag("thuyen"))
        {
           // check = true;
        }
        else if (other.gameObject.CompareTag("thangmay"))
        {
            //this.transform.position += transform.forward * elevator.Instance.flag * Time.deltaTime;
        }
      
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("thuyen"))
        {
            check = false;
        }
        else if (other.gameObject.CompareTag("thangmay"))
        {
            check = false;

        }
        else if (other.gameObject.CompareTag("thothut"))
        {
            check = false;

        }
        else if (other.gameObject.CompareTag("thothut"))
        {
            check = false;
        }
        else if (other.gameObject.CompareTag("fire"))
        {
            checkFire = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void checkDead()
    {
        if (Health < 1)
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            LevelLoader.Instance.LoadEnd();
        else
            FuncBlood();
    }

    IEnumerator DelayFire(TextMeshProUGUI healthText)
    {
        while (Health > 0 && checkFire == true)
       {
            Health -= 1;
            if (Health < 1) Health = 0;
            checkDead();

            healthText.text = Health.ToString() + "/100";
            FuncBlood();

            yield return new WaitForSeconds(1);
        }
        //DelayFire(healthText);
    }

    private void FuncBlood()
    {
       // blood.SetActive(true);
        BloodController.Instance.LoadBlood();
    }
}
