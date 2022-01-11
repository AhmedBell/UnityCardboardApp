using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grap : MonoBehaviour
{
   // private GameObject cube;
    public GameObject Hands;
    public GameObject Weapons;
    bool CanGrap = true;
    bool inHands = false;
    Vector3 ballPos;
    Quaternion wRotation;
 
    //string name = "none";
    // Start is called before the first frame update
    void Start()
    {
        
        ballPos = this.transform.position;
        wRotation = this.transform.rotation;
        // Update is called once per frame
    }
    void Update()
        {

      
         
        if (Input.GetButtonDown("Fire1"))
        {
           
                if (!inHands )
              
                {
               
                    this.transform.SetParent(Hands.transform);
                    this.transform.localPosition = new Vector3(0.173f, -.293f, 0.278f);
                this.transform.rotation = Quaternion.Euler(10,90,0);
                    inHands = true;
                

                }

                else if (inHands  )
                {
                    this.GetComponent<Grap>().enabled = false;
                    this.transform.SetParent(Weapons.transform);
                    this.transform.localPosition = ballPos;
                this.transform.rotation = wRotation;

                    inHands = false;
                }
            }


        if (this.transform.parent == Hands.transform)
        {
            GetComponent<Renderer>().material.color = Color.cyan;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        }
    
}