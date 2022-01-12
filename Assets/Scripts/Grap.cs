using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grap : MonoBehaviour
{
  
    public GameObject Hands;
    public GameObject Weapons;
    bool inHands = false;
    Vector3 weaponPos;
    Quaternion wRotation;
    
    
 
   
    // Start is called before the first frame update
    void Start()
    {
        
        weaponPos = this.transform.position;
        wRotation = this.transform.rotation;
      
      
    }
    // Update is called once per frame
    void Update()
        {

      
         
        if (Input.GetButtonDown("Fire1"))
        {
           
                if (!inHands )
              
                {
               
                    this.transform.SetParent(Hands.transform);
                    this.transform.localPosition = new Vector3(0.173f, -.293f, 0.278f);
                this.transform.rotation = Quaternion.Euler(7,90,0);
               
                    inHands = true;
                

                }

                else if (inHands  )
                {
              
                    this.GetComponent<Grap>().enabled = false;
                    this.transform.SetParent(Weapons.transform);
                    this.transform.localPosition = weaponPos;
                this.transform.rotation = wRotation;

                    inHands = false;
                }
            }


       
        }
    
}