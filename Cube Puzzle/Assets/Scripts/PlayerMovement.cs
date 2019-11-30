using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform player;
    AudioSource AudioSource;
    public AudioClip tap;
    float nextstep = 0;
    public float waitTime = .8f;
    public GameObject panel;
    public GameObject panel1;

    // Start is called before the first frame update
    private void Awake()
    {
        panel.SetActive(false);
        panel1.SetActive(false);
       // Time.timeScale = 1;
    }
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Spawner1")
        {
            collision.gameObject.GetComponent<FloorManager>().Spawner1();
        }
        if (collision.gameObject.tag == "Spawner2")
        {
            collision.gameObject.GetComponent<FloorManager>().Spawner2();
        }
        if(collision.gameObject.tag == "enemy")
        {
            panel.SetActive(true);
            //Time.timeScale = 0;
        }if(collision.gameObject.tag == "Finish")
        {
            panel1.SetActive(true);
            //Time.timeScale = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        player.transform.position = transform.position;
        GameObject child;
        if (Input.GetKeyDown(KeyCode.UpArrow) && Time.time>nextstep)
        {
            nextstep = Time.time + waitTime;
            child = GameObject.Find("Back");
            AudioSource.PlayOneShot(tap);
            transform.RotateAround(child.transform.position, Vector3.left, 180);
            transform.position = new Vector3(transform.position.x, 1, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && Time.time>nextstep)
        {
            nextstep = Time.time + waitTime;
            child = GameObject.Find("Front");
            AudioSource.PlayOneShot(tap);
            transform.RotateAround(child.transform.position, Vector3.left, -180);
            transform.position = new Vector3(transform.position.x, 1, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && Time.time>nextstep)
        {
            nextstep = Time.time + waitTime;
            child = GameObject.Find("Right");
            AudioSource.PlayOneShot(tap);
            transform.RotateAround(child.transform.position, Vector3.forward, -180);
            transform.position = new Vector3(transform.position.x, 1, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && Time.time>nextstep)
        {
            nextstep = Time.time + waitTime;
            child = GameObject.Find("Left");
            AudioSource.PlayOneShot(tap);
            transform.RotateAround(child.transform.position, Vector3.forward, 180);
            transform.position = new Vector3(transform.position.x, 1, transform.position.z);
        }
    }
}
