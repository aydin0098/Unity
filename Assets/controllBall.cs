using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class controllBall : MonoBehaviour
{
    public Rigidbody rigid;
    public float speed = 1;
    public float speedh = 1;

    public Canvas canvas;

    bool isLose = false;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
      
      float h = Input.GetAxis("Horizontal")*speedh * Time.deltaTime;
      rigid.AddForce(h,0,1*speed*Time.deltaTime);
      if(isLose && Input.anyKeyDown)
      {
         SceneManager.LoadSceneAsync(0);
      }
     

      
    }

    private void OnCollisionEnter(Collision collision) {

      if(collision.transform.tag == "Enemy")
      {
        canvas.enabled = true;
        isLose = true;
        Time.timeScale = 0;
       
      }
    }
}
