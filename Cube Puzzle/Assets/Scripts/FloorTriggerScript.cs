using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTriggerScript : MonoBehaviour
{

    public Animator anim;
    public Animator anim1;
    public Animator anim2;

    bool gg = false;
    private void Update()
    {
        if (gg)
        {
            Debug.Log("gg");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool("Open", true);
            anim1.SetBool("Open", true);
           
        }
    }
    private void OnTriggerStay(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            anim2.SetBool("in", true);
        }
    }private void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Invoke("up", 2f);
        }
    }
    void up()
    {
        anim.SetBool("Open", false);
        anim2.SetBool("in", false);
    }

}
