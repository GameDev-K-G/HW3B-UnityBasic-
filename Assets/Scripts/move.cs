using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    Rigidbody2D myRigid;
    float x,y ;
    // Start is called before the first frame update
    void Start()
    {
        myRigid=GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        x=Input.GetAxis("Horizontal");
        y=Input.GetAxis("Vertical");
        myRigid.velocity=new Vector2(x*5,y*5);


        
    }
}
