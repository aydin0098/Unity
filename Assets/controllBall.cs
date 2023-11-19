using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllBall : MonoBehaviour
{
    public Rigidbody rigid;
    public float speed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
      float h = Input.GetAxis("Horizontal")*speed * Time.deltaTime;
      rigid.AddForce(h,0,1*speed*Time.deltaTime);
    }
}
