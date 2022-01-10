using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grap : MonoBehaviour
{
   // private GameObject cube;
    public GameObject Hands;
    public GameObject cubes;
    bool CanGrap = true;
    bool inHands = false;
    Vector3 ballPos;
    // Start is called before the first frame update
    void Start()
    {
       
        ballPos = this.transform.position;
        // Update is called once per frame
    }
    void Update()
        {

     

        if (Input.GetButtonDown("Fire1"))
        {
            
                if (!inHands)
                {
                    this.transform.SetParent(Hands.transform);
                    this.transform.localPosition = new Vector3(-0.05f, -.5f, 0.87f);
                    inHands = true;


                }

                else if (inHands)
                {
                    this.GetComponent<Grap>().enabled = false;
                    this.transform.SetParent(cubes.transform);
                    this.transform.localPosition = ballPos;

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