using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grap1 : MonoBehaviour
{
    // private GameObject cube;
    public GameObject Hands;
    public GameObject cubes;
    public GameObject[] cube;
    bool inHands = false;
    Vector3 ballPos;
    public GvrBasePointer ray;
    // Start is called before the first frame update
    void Start()
    {
        if (cube == null)  
        cube = GameObject.FindGameObjectsWithTag("Cube");
        ballPos = this.transform.position;
       
    }
    // Update is called once per frame
    void Update()
    {

        

        if (Input.GetButtonDown("Fire1"))
        {
            foreach (GameObject cu in cube)
            {
                if (!inHands)
                {

                    cu.transform.SetParent(Hands.transform);
                    cu.transform.localPosition = new Vector3(-0.05f, -.5f, 0.87f);
                    inHands = true;


                }

                else if (inHands)
                {
                    this.GetComponent<Grap>().enabled = false;
                    cu.transform.SetParent(cubes.transform);
                    cu.transform.localPosition = ballPos;

                    inHands = false;
                }
            }
        }
        Debug.Log(Hands.transform.childCount);


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
