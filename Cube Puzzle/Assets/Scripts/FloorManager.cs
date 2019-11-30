using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorManager : MonoBehaviour
{
    public GameObject Floors;
    public Vector3 FloorPosition;
    public float WaitTime;


    public void Spawner2()
    {
        StartCoroutine(FloorSpawner2());
    }
    public void Spawner1()
    {
        StartCoroutine(FloorSpawner());
    }


    IEnumerator FloorSpawner()
    {
        for (int i = 0; i < 15; i++)
        {
           
            FloorPosition = new Vector3(-10-i, 0, -7);
            yield return new WaitForSeconds(WaitTime);
            Instantiate(Floors, FloorPosition, transform.rotation);
        }
        
    }
    IEnumerator FloorSpawner2()
    {
        for (int i = 0; i < 15; i++)
        {

            FloorPosition = new Vector3(-26.01f, 0, -10-i);
            yield return new WaitForSeconds(WaitTime);
            Instantiate(Floors, FloorPosition, transform.rotation);
        }

    }

}
