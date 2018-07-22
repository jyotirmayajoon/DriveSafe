using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorL3Script : MonoBehaviour {
    //private bool beingHandled = false;
    // Use this for initialization
    void Start ()
    {

        this.GetComponent<Light>().enabled = false;
        InvokeRepeating("HandleIt", 17.0f, 0.3f);
        //StartCoroutine(wait1());

    }
    /*void Update()
    {
        if (this.transform.position.z > 26f && this.transform.position.z < 50f)
        {
            
            {
                if (this.GetComponent<Light>().enabled == false)
                {
                    this.GetComponent<Light>().enabled = true;
                }
                 new WaitForSeconds(2); Debug.Log("here");
                if (this.GetComponent<Light>().enabled == true)
                {
                    this.GetComponent<Light>().enabled = false;
                }
                 new WaitForSeconds(2);
            }
        }
    }*/
    // Update is called once per frame


    

    void Update()
    {
        if(Time.timeSinceLevelLoad>=20f)
        {
           CancelInvoke();
            this.GetComponent<Light>().enabled = false ;
        }
    }

    void HandleIt()
    {
        //beingHandled = true;
        // process pre-yield
        //yield return new WaitForSeconds(0.5f);

        if (this.GetComponent<Light>().enabled == false)
        {
            this.GetComponent<Light>().enabled = true;
        }
        
        else
        {
            this.GetComponent<Light>().enabled = false;
        }
       // yield return new WaitForSeconds(0.5f);
       // beingHandled = false;
    }

    /* IEnumerator wait1()
     {
         if (this.transform.position.z > 26f && this.transform.position.z < 50)
         {
             while (this.transform.position.z > 26f && this.transform.position.z < 50f)
             {
                 if (this.GetComponent<Light>().enabled == false)
                 {
                     this.GetComponent<Light>().enabled = true;
                 }
                 yield return new WaitForSeconds(2); Debug.Log("here");
                 if (this.GetComponent<Light>().enabled == true)
                 {
                     this.GetComponent<Light>().enabled = false;
                 }
                 yield return new WaitForSeconds(2);
             }
         }
         else
         {
             StartCoroutine(wait1());
         }
        // Number = 2;
     }*/
    /*IEnumerator wait2()
    {
        this.GetComponent<Light>().enabled = false;
        yield return new WaitForSeconds(200);
        // Number = 2;
    }*/
}
