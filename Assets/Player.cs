using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Player : MonoBehaviour
{
    public Transform playerSpawnPoints;
    Transform[] spawnPoints;
    public bool respawn = false;
    public bool lastToggle = false;
    int i;
     FirstPersonController temp;

    void Start()
    {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
        //Debug.Log(spawnPoints.Length);
        //print(spawnPoints.Length);
        temp = GetComponent<FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(lastToggle!=respawn)
        {
            Respawn();
            temp.enabled = false;
            respawn = false;
        }
        else
        {
            temp.enabled = true;
            lastToggle = respawn;
        }
       
    }

    public void Respawn()
    {
        int i = Random.Range(1, spawnPoints.Length);
        transform.position = spawnPoints[i].transform.position;
    }

}
